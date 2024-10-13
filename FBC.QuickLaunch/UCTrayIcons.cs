using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FBC.QuickLaunch
{
    public enum UCTrayIconsModification
    {
        None,
        Add,
        Edit,
        Delete,
        ChangeOrder
    }
    public partial class UCTrayIcons : UserControl
    {
        public UCTrayIcons()
        {
            InitializeComponent();
            lbTrayIcons.DisplayMember = "Title";
            lbTrayIcons.Items.Clear();
            handleSelectedIndexChanged();
        }
        public event EventHandler<UCTrayIconsModification> IconsModified;
        private void CallIconsModified(UCTrayIconsModification modification)
        {
            IconsModified?.Invoke(this, modification);
        }

        public List<TrayIcon> TrayIcons
        {
            get
            {
                //Get the list of tray icons from list box name lbTrayIcons
                return lbTrayIcons.Items.Cast<TrayIcon>().ToList();
            }
            set
            {
                //Set the list of tray icons to list box name lbTrayIcons
                lbTrayIcons.Items.Clear();
                foreach (var item in value)
                {
                    lbTrayIcons.Items.Add(item);
                }
                handleSelectedIndexChanged();
            }
        }


        private void btnNew_Click(object sender, EventArgs e)
        {
            lbTrayIcons.Items.Add(new TrayIcon());
            CallIconsModified(UCTrayIconsModification.Add);

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lbTrayIcons.SelectedItems.Count > 0)
            {
                //Remove all selected items from list box name lbTrayIcons
                var selectedItems = new List<TrayIcon>();
                foreach (var item in lbTrayIcons.SelectedItems)
                {
                    selectedItems.Add((TrayIcon)item);
                }
                foreach (var item in selectedItems)
                {
                    lbTrayIcons.Items.Remove(item);
                }
                CallIconsModified(UCTrayIconsModification.Delete);
            }
        }
        List<TrayIcon> selectedItems = new();
        void backupSelectedIndexes()
        {
            selectedItems.Clear();
            foreach (var item in lbTrayIcons.SelectedItems)
            {
                selectedItems.Add((TrayIcon)item);
            }
        }
        void restoreSelectedIndexes()
        {
            lbTrayIcons.ClearSelected();
            foreach (var item in selectedItems)
            {
                lbTrayIcons.SelectedItems.Add(item);
            }
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            //Move the selected items one position up in the list box name lbTrayIcons
            backupSelectedIndexes();
            bool changed = false;
            foreach (var item in selectedItems)
            {
                var index = lbTrayIcons.Items.IndexOf(item);
                if (index > 0)
                {
                    lbTrayIcons.Items.Remove(item);
                    lbTrayIcons.Items.Insert(index - 1, item);
                    changed = true;
                }

            }
            restoreSelectedIndexes();
            if (changed)
            {
                CallIconsModified(UCTrayIconsModification.ChangeOrder);
            }
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            backupSelectedIndexes();
            bool changed = false;
            foreach (var item in selectedItems)
            {
                var index = lbTrayIcons.Items.IndexOf(item);
                if (index < lbTrayIcons.Items.Count - 1)
                {
                    lbTrayIcons.Items.Remove(item);
                    lbTrayIcons.Items.Insert(index + 1, item);
                    changed = true;
                }
            }
            restoreSelectedIndexes();
            if (changed)
            {
                CallIconsModified(UCTrayIconsModification.ChangeOrder);
            }
        }

        private void handleSelectedIndexChanged()
        {
            //Assign the selected item to the ucSelectedTrayIcon control's model property
            if (lbTrayIcons.SelectedItem != null)
            {
                ucSelectedTrayIcon.Model = ((TrayIcon)lbTrayIcons.SelectedItem).Clone();
                ucSelectedTrayIcon.SaveCliked += (s, ev) =>
                {
                    lbTrayIcons.Items[lbTrayIcons.SelectedIndex] = ucSelectedTrayIcon.Model;
                    CallIconsModified(UCTrayIconsModification.Edit);
                };
                ucSelectedTrayIcon.CancelClicked += (s, ev) =>
                {
                    ucSelectedTrayIcon.Model = ((TrayIcon)lbTrayIcons.SelectedItem).Clone();
                };
                ucSelectedTrayIcon.Enabled = true;

            }
            else
            {
                ucSelectedTrayIcon.Model = new TrayIcon();
                ucSelectedTrayIcon.Enabled = false;
            }
        }

        private void lbTrayIcons_SelectedIndexChanged(object sender, EventArgs e)
        {
            handleSelectedIndexChanged();
        }

        private void btnNewFromFiles_Click(object sender, EventArgs e)
        {
            //Open a file dialog to select executable files to add to the list box name lbTrayIcons
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Executable files (*.exe)|*.exe";
                ofd.Multiselect = true;
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    bool changed = false;
                    foreach (var file in ofd.FileNames)
                    {
                        lbTrayIcons.Items.Add(new TrayIcon(file));
                        changed = true;
                    }
                    if (changed)
                    {
                        CallIconsModified(UCTrayIconsModification.Add);
                    }
                }
            }
        }
    }
}
