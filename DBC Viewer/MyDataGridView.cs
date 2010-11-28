using System.Windows.Forms;

namespace DBCViewer
{
    public class MyDataGridView : DataGridView
    {
        public MyDataGridView() : base()
        {
            this.SetStyle(ControlStyles.DoubleBuffer | ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint, true);
            this.UpdateStyles();
        }
    }
}
