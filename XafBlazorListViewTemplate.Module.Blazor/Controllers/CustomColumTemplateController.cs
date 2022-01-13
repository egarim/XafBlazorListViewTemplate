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
