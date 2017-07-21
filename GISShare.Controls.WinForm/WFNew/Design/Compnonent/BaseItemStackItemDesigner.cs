using System;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace GISShare.Controls.WinForm.WFNew.Design
{
    public class BaseItemStackItemDesigner : ComponentDesigner
    {
        private BaseItemStackItem m_BaseItemStackItem = null;

        public override void Initialize(IComponent component)
        {
            base.Initialize(component);
            //
            this.m_BaseItemStackItem = base.Component as BaseItemStackItem;
            if (this.m_BaseItemStackItem == null)
            {
                GISShare.Controls.WinForm.WFNew.Forms.TBMessageBox.Show("BaseItemStackItem == null");
                return;
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                foreach (BaseItem one in this.m_BaseItemStackItem.BaseItems)
                {
                    one.Dispose();
                }
                this.m_BaseItemStackItem.BaseItems.Clear();
            }
            base.Dispose(disposing);
        }

        public override DesignerVerbCollection Verbs
        {
            get
            {
                DesignerVerbCollection verbs = new DesignerVerbCollection();
                //
                verbs.Add(new DesignerVerb("��ϵ�������", new EventHandler(BuildTreeView)));
                ////
                //verbs.Add(new DesignerVerb("���� LabelItem", new EventHandler(AddLabelItem)));
                //verbs.Add(new DesignerVerb("���� LinkLabelItem", new EventHandler(AddLinkLabelItem)));
                //verbs.Add(new DesignerVerb("���� BaseButtonItem", new EventHandler(AddBaseButtonItem)));
                //verbs.Add(new DesignerVerb("���� DropDownButtonItem", new EventHandler(AddDropDownButtonItem)));
                //verbs.Add(new DesignerVerb("���� SplitButtonItem", new EventHandler(AddSplitButtonItem)));
                //verbs.Add(new DesignerVerb("���� ButtonItem", new EventHandler(AddButtonItem)));
                //verbs.Add(new DesignerVerb("���� CheckButtonItem", new EventHandler(AddCheckButtonItem)));
                //verbs.Add(new DesignerVerb("���� CheckBoxItem", new EventHandler(AddCheckBoxItem)));
                //verbs.Add(new DesignerVerb("���� RadioButtonItem", new EventHandler(AddRadioButtonItem)));
                //verbs.Add(new DesignerVerb("���� TextBoxItem", new EventHandler(AddTextBoxItem)));
                //verbs.Add(new DesignerVerb("���� ComboBoxItem", new EventHandler(AddComboBoxItem)));
                //verbs.Add(new DesignerVerb("���� ComboTreeItem", new EventHandler(AddComboTreeItem)));
                //verbs.Add(new DesignerVerb("���� SeparatorItem", new EventHandler(AddSeparatorItem)));
                //verbs.Add(new DesignerVerb("���� LabelSeparatorItem", new EventHandler(AddLabelSeparatorItem)));
                //verbs.Add(new DesignerVerb("���� ButtonGroupItem", new EventHandler(AddButtonGroupItem)));
                //verbs.Add(new DesignerVerb("���� RibbonGalleryItem", new EventHandler(AddRibbonGalleryItem)));
                //verbs.Add(new DesignerVerb("���� BaseItemStackItem", new EventHandler(AddBaseItemStackItem)));
                //verbs.Add(new DesignerVerb("���� BaseItemStackExItem", new EventHandler(AddBaseItemStackExItem)));
                //
                return verbs;
            }
        }

        #region old
        //private void AddLabelItem(object sender, EventArgs ea)
        //{
        //    IDesignerHost host = (IDesignerHost)GetService(typeof(IDesignerHost));
        //    if (host != null)
        //    {
        //        LabelItem baseItem = host.CreateComponent(typeof(LabelItem)) as LabelItem;
        //        baseItem.Name = baseItem.Site.Name;
        //        baseItem.Text = baseItem.Name;
        //        baseItem.Size = new Size(60, 21);
        //        this.m_BaseItemStackItem.BaseItems.Add(baseItem);
        //    }

        //}

        //private void AddLinkLabelItem(object sender, EventArgs ea)
        //{
        //    IDesignerHost host = (IDesignerHost)GetService(typeof(IDesignerHost));
        //    if (host != null)
        //    {
        //        LinkLabelItem baseItem = host.CreateComponent(typeof(LinkLabelItem)) as LinkLabelItem;
        //        baseItem.Name = baseItem.Site.Name;
        //        baseItem.Text = baseItem.Name;
        //        baseItem.Size = new Size(60, 21);
        //        this.m_BaseItemStackItem.BaseItems.Add(baseItem);
        //    }

        //}

        //private void AddBaseButtonItem(object sender, EventArgs ea)
        //{
        //    IDesignerHost host = (IDesignerHost)GetService(typeof(IDesignerHost));
        //    if (host != null)
        //    {
        //        BaseButtonItem baseItem = host.CreateComponent(typeof(BaseButtonItem)) as BaseButtonItem;
        //        baseItem.Name = baseItem.Site.Name;
        //        baseItem.Text = baseItem.Name;
        //        baseItem.ShowNomalState = false;
        //        baseItem.Size = new Size(60, 23);
        //        this.m_BaseItemStackItem.BaseItems.Add(baseItem);
        //    }
        //}

        //private void AddDropDownButtonItem(object sender, EventArgs ea)
        //{
        //    IDesignerHost host = (IDesignerHost)GetService(typeof(IDesignerHost));
        //    if (host != null)
        //    {
        //        DropDownButtonItem baseItem = host.CreateComponent(typeof(DropDownButtonItem)) as DropDownButtonItem;
        //        baseItem.Name = baseItem.Site.Name;
        //        baseItem.Text = baseItem.Name;
        //        baseItem.eArrowDock = ArrowDock.eRight;
        //        baseItem.ShowNomalState = false;
        //        baseItem.Size = new Size(60, 23);
        //        this.m_BaseItemStackItem.BaseItems.Add(baseItem);
        //    }
        //}

        //private void AddSplitButtonItem(object sender, EventArgs ea)
        //{
        //    IDesignerHost host = (IDesignerHost)GetService(typeof(IDesignerHost));
        //    if (host != null)
        //    {
        //        SplitButtonItem baseItem = host.CreateComponent(typeof(SplitButtonItem)) as SplitButtonItem;
        //        baseItem.Name = baseItem.Site.Name;
        //        baseItem.Text = baseItem.Name;
        //        baseItem.eArrowDock = ArrowDock.eRight;
        //        baseItem.ShowNomalState = false;
        //        baseItem.Size = new Size(60, 23);
        //        this.m_BaseItemStackItem.BaseItems.Add(baseItem);
        //    }
        //}

        //private void AddButtonItem(object sender, EventArgs ea)
        //{
        //    IDesignerHost host = (IDesignerHost)GetService(typeof(IDesignerHost));
        //    if (host != null)
        //    {
        //        ButtonItem baseItem = host.CreateComponent(typeof(ButtonItem)) as ButtonItem;
        //        baseItem.Name = baseItem.Site.Name;
        //        baseItem.Text = baseItem.Name;
        //        baseItem.ShowNomalState = false;
        //        baseItem.Size = new Size(60, 23);
        //        this.m_BaseItemStackItem.BaseItems.Add(baseItem);
        //    }
        //}

        //private void AddCheckButtonItem(object sender, EventArgs ea)
        //{
        //    IDesignerHost host = (IDesignerHost)GetService(typeof(IDesignerHost));
        //    if (host != null)
        //    {
        //        CheckButtonItem baseItem = host.CreateComponent(typeof(CheckButtonItem)) as CheckButtonItem;
        //        baseItem.Name = baseItem.Site.Name;
        //        baseItem.Text = baseItem.Name;
        //        baseItem.ShowNomalState = false;
        //        baseItem.Size = new Size(60, 21);
        //        this.m_BaseItemStackItem.BaseItems.Add(baseItem);
        //    }

        //}

        //private void AddCheckBoxItem(object sender, EventArgs ea)
        //{
        //    IDesignerHost host = (IDesignerHost)GetService(typeof(IDesignerHost));
        //    if (host != null)
        //    {
        //        CheckBoxItem baseItem = host.CreateComponent(typeof(CheckBoxItem)) as CheckBoxItem;
        //        baseItem.Name = baseItem.Site.Name;
        //        baseItem.Text = baseItem.Name;
        //        baseItem.Size = new Size(60, 21);
        //        this.m_BaseItemStackItem.BaseItems.Add(baseItem);
        //    }

        //}

        //private void AddRadioButtonItem(object sender, EventArgs ea)
        //{
        //    IDesignerHost host = (IDesignerHost)GetService(typeof(IDesignerHost));
        //    if (host != null)
        //    {
        //        RadioButtonItem baseItem = host.CreateComponent(typeof(RadioButtonItem)) as RadioButtonItem;
        //        baseItem.Name = baseItem.Site.Name;
        //        baseItem.Text = baseItem.Name;
        //        baseItem.Size = new Size(60, 21);
        //        this.m_BaseItemStackItem.BaseItems.Add(baseItem);
        //    }

        //}

        //private void AddTextBoxItem(object sender, EventArgs ea)
        //{
        //    IDesignerHost host = (IDesignerHost)GetService(typeof(IDesignerHost));
        //    if (host != null)
        //    {
        //        TextBoxItem baseItem = host.CreateComponent(typeof(TextBoxItem)) as TextBoxItem;
        //        baseItem.Name = baseItem.Site.Name;
        //        baseItem.Text = baseItem.Name;
        //        baseItem.Size = new Size(60, 21);
        //        this.m_BaseItemStackItem.BaseItems.Add(baseItem);
        //    }

        //}

        //private void AddComboBoxItem(object sender, EventArgs ea)
        //{
        //    IDesignerHost host = (IDesignerHost)GetService(typeof(IDesignerHost));
        //    if (host != null)
        //    {
        //        ComboBoxItem baseItem = host.CreateComponent(typeof(ComboBoxItem)) as ComboBoxItem;
        //        baseItem.Name = baseItem.Site.Name;
        //        //baseItem.Text = baseItem.Name;
        //        baseItem.Size = new Size(60, 21);
        //        this.m_BaseItemStackItem.BaseItems.Add(baseItem);
        //    }

        //}

        //private void AddComboTreeItem(object sender, EventArgs ea)
        //{
        //    IDesignerHost host = (IDesignerHost)GetService(typeof(IDesignerHost));
        //    if (host != null)
        //    {
        //        ComboTreeItem baseItem = host.CreateComponent(typeof(ComboTreeItem)) as ComboTreeItem;
        //        baseItem.Name = baseItem.Site.Name;
        //        //baseItem.Text = baseItem.Name;
        //        baseItem.Size = new Size(60, 21);
        //        this.m_BaseItemStackItem.BaseItems.Add(baseItem);
        //    }

        //}

        //private void AddSeparatorItem(object sender, EventArgs ea)
        //{
        //    IDesignerHost host = (IDesignerHost)GetService(typeof(IDesignerHost));
        //    if (host != null)
        //    {
        //        SeparatorItem baseItem = host.CreateComponent(typeof(SeparatorItem)) as SeparatorItem;
        //        baseItem.Name = baseItem.Site.Name;
        //        baseItem.Text = baseItem.Name;
        //        switch (this.m_BaseItemStackItem.eOrientation)
        //        {
        //            case Orientation.Vertical:
        //                baseItem.eOrientation = Orientation.Horizontal;
        //                baseItem.Size = new Size(23, 2);
        //                break;
        //            case Orientation.Horizontal:
        //                baseItem.eOrientation = Orientation.Vertical;
        //                baseItem.Size = new Size(2, 23);
        //                break;
        //        }
        //        this.m_BaseItemStackItem.BaseItems.Add(baseItem);
        //    }
        //}

        //private void AddLabelSeparatorItem(object sender, EventArgs ea)
        //{
        //    IDesignerHost host = (IDesignerHost)GetService(typeof(IDesignerHost));
        //    if (host != null)
        //    {
        //        LabelSeparatorItem baseItem = host.CreateComponent(typeof(LabelSeparatorItem)) as LabelSeparatorItem;
        //        baseItem.Name = baseItem.Site.Name;
        //        baseItem.Text = baseItem.Name;
        //        baseItem.Size = new Size(60, 21);
        //        this.m_BaseItemStackItem.BaseItems.Add(baseItem);
        //    }

        //}

        //private void AddButtonGroupItem(object sender, EventArgs ea)
        //{
        //    IDesignerHost host = (IDesignerHost)GetService(typeof(IDesignerHost));
        //    if (host != null)
        //    {
        //        ButtonGroupItem baseItem = host.CreateComponent(typeof(ButtonGroupItem)) as ButtonGroupItem;
        //        baseItem.Name = baseItem.Site.Name;
        //        baseItem.Text = baseItem.Name;
        //        baseItem.Size = new Size(23, 23);
        //        this.m_BaseItemStackItem.BaseItems.Add(baseItem);
        //    }

        //}

        //private void AddRibbonGalleryItem(object sender, EventArgs ea)
        //{
        //    IDesignerHost host = (IDesignerHost)GetService(typeof(IDesignerHost));
        //    if (host != null)
        //    {
        //        RibbonGalleryItem baseItem = host.CreateComponent(typeof(RibbonGalleryItem)) as RibbonGalleryItem;
        //        baseItem.Name = baseItem.Site.Name;
        //        baseItem.Text = baseItem.Name;
        //        baseItem.Size = new Size(70, 70);
        //        this.m_BaseItemStackItem.BaseItems.Add(baseItem);
        //    }
        //}

        //private void AddBaseItemStackItem(object sender, EventArgs ea)
        //{
        //    IDesignerHost host = (IDesignerHost)GetService(typeof(IDesignerHost));
        //    if (host != null)
        //    {
        //        BaseItemStackItem baseItem = host.CreateComponent(typeof(BaseItemStackItem)) as BaseItemStackItem;
        //        baseItem.Name = baseItem.Site.Name;
        //        baseItem.Text = baseItem.Name;
        //        switch (this.m_BaseItemStackItem.eOrientation)
        //        {
        //            case Orientation.Horizontal:
        //                baseItem.eOrientation = Orientation.Vertical;
        //                baseItem.ColumnDistance = 0;
        //                break;
        //            case Orientation.Vertical:
        //                baseItem.eOrientation = Orientation.Horizontal;
        //                baseItem.LineDistance = 0;
        //                break;
        //        }
        //        baseItem.Size = new Size(60, 23);
        //        this.m_BaseItemStackItem.BaseItems.Add(baseItem);
        //    }
        //}

        //private void AddBaseItemStackExItem(object sender, EventArgs ea)
        //{
        //    IDesignerHost host = (IDesignerHost)GetService(typeof(IDesignerHost));
        //    if (host != null)
        //    {
        //        BaseItemStackExItem baseItem = host.CreateComponent(typeof(BaseItemStackExItem)) as BaseItemStackExItem;
        //        baseItem.Name = baseItem.Site.Name;
        //        baseItem.Text = baseItem.Name;
        //        baseItem.IsStretchItems = true;
        //        baseItem.IsRestrictSize = false;
        //        switch (this.m_BaseItemStackItem.eOrientation)
        //        {
        //            case Orientation.Horizontal:
        //                baseItem.eOrientation = Orientation.Vertical;
        //                baseItem.ColumnDistance = 0;
        //                break;
        //            case Orientation.Vertical:
        //                baseItem.eOrientation = Orientation.Horizontal;
        //                baseItem.LineDistance = 0;
        //                break;
        //        }
        //        baseItem.Size = new Size(60, 23);
        //        this.m_BaseItemStackItem.BaseItems.Add(baseItem);
        //    }
        //}
        #endregion

        //

        private void BuildTreeView(object sender, EventArgs ea)
        {
            //BaseItemCollectionEditerForm baseItemCollectionDesignerForm = new BaseItemCollectionEditerForm(this.m_RibbonControl);
            //baseItemCollectionDesignerForm.GetServiceCallBackEx = new GetServiceCallBack(this.GetService);
            //baseItemCollectionDesignerForm.TopMost = true;
            //baseItemCollectionDesignerForm.Location = new Point(360, 150);
            //baseItemCollectionDesignerForm.Show();
            BaseItemCollectionDesignerFormEx baseItemCollectionDesignerFormEx = new BaseItemCollectionDesignerFormEx(this.m_BaseItemStackItem);
            baseItemCollectionDesignerFormEx.GetServiceCallBackEx = new GetServiceCallBack(this.GetService);
            baseItemCollectionDesignerFormEx.TopMost = true;
            baseItemCollectionDesignerFormEx.Location = new Point(360, 150);
            baseItemCollectionDesignerFormEx.Show();
        }
    }
}