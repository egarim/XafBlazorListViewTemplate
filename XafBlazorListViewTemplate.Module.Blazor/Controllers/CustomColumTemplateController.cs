using DevExpress.Blazor;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Blazor.Editors.Grid;
using DevExpress.ExpressApp.Blazor.Editors.Grid.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XafBlazorListViewTemplate.Module.BusinessObjects;

namespace XafBlazorListViewTemplate.Module.Blazor.Controllers
{
    public partial class CustomColumTemplateController : ObjectViewController<ListView,Person>
    {
        public CustomColumTemplateController()
        {
            //HACK https://supportcenter.devexpress.com/ticket/details/t1037946/xaf-blazor-how-allow-user-to-click-a-hyperlink-or-press-a-button-to-open-such-hyperlink
            //HACK https://docs.devexpress.com/eXpressAppFramework/402154/getting-started/in-depth-tutorial-blazor/extend-functionality/access-data-grid-settings?utm_source=SupportCenter&utm_medium=website&utm_campaign=docs-feedback&utm_content=T1037946&contactId=A912744
            //HACK https://supportcenter.devexpress.com/ticket/details/t961969/xaf-blazor-use-templates-in-grid

        }
        protected override void OnViewControlsCreated()
        {
            base.OnViewControlsCreated();
            GridListEditor gridListEditor = (GridListEditor)View.Editor;
          
            IDxDataGridAdapter dataGridAdapter = gridListEditor.GetDataGridAdapter();

           



            foreach (DxDataGridColumnModel columnModel in dataGridAdapter.DataGridColumnModels)
            {
                if (columnModel.Field ==nameof(Person.Email))
                {
                    columnModel.DisplayTemplate = LinkColumnTemplate.Create();
                   
                }
            }
        }
        // ...
        //protected override void OnViewControlsCreated()
        //{
        //    base.OnViewControlsCreated();
        //    if (View.Editor is GridListEditor gridListEditor)
        //    {
        //        IDxDataGridAdapter dataGridAdapter = gridListEditor.GetDataGridAdapter();
        //        dataGridAdapter.DataGridModel.ColumnResizeMode = DataGridColumnResizeMode.Component;
        //        //var columns=dataGridAdapter.ComponentContent.
        //    }
        //}
        // ...
    }
}
