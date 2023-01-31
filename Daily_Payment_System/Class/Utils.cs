using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Daily_Payment_System.Class
{
    class Utils
    {
        public static List<tbl_category> categories()
        {
            var query = ConstantField.entities.tbl_category.Where(f=>f.status == true).ToList();
            return query;
        }

        public static List<vw_select_product> GetProducts()
        {
            var query = ConstantField.entities.vw_select_product.ToList();
            return query;
        }

        public static List<tbl_category> GetCategories()
        {
            var query = ConstantField.entities.tbl_category.ToList();
            return query;
        }

        public static List<tbl_supplier> GetSuplier()
        {
            var query = ConstantField.entities.tbl_supplier.ToList();
            return query;
        }

        public static List<vw_select_stock> GetStock()
        {
            var query = ConstantField.entities.vw_select_stock.ToList();
            return query;
        }

        public static void loadCategory(ComboBox cboCategory,bool showFirst)
        {
            cboCategory.DataSource = categories();
            cboCategory.DisplayMember = "category";
            cboCategory.ValueMember = "cat_id";
            if (!showFirst) { cboCategory.SelectedIndex = -1; }
        }

        public static void loadProduct(ComboBox cboProduct, bool showFirst)
        {
            cboProduct.DataSource = GetProducts();
            cboProduct.DisplayMember = "pro_name";
            cboProduct.ValueMember = "pro_id";
            if (!showFirst) { cboProduct.SelectedIndex = -1; }
        }

        public static void loadSuplier(ComboBox cboSuplier, bool showFirst)
        {
            cboSuplier.DataSource = GetSuplier();
            cboSuplier.DisplayMember = "spl_name";
            cboSuplier.ValueMember = "spl_id";
            if (!showFirst) { cboSuplier.SelectedIndex = -1; }
        }

        static public byte[] saveImage(string path)
        {
            byte[] data = null;
            FileInfo infor = new FileInfo(path);
            long num = infor.Length;
            FileStream str = new FileStream(path, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(str);
            data = br.ReadBytes((int)num);
            return data;
        }

    }
}
