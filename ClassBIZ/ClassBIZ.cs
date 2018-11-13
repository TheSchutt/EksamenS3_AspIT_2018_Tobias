using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IOLayer;
using System.Data.Entity;
using System.Windows;
using System.Data.Entity.Validation;
using System.Collections.ObjectModel;
using Repository;
using System.Data;
using System.Windows.Controls;

namespace ClassBIZ
{
    public class ClassBiz : ClassNotify
    {
        private GrainContext getData = new GrainContext();
        AsynchronousClient AC = new AsynchronousClient();
        public ClassSupllier classSupllierEdit = new ClassSupllier();
        public ClassSaleAssistant classSaleAssistantEdit = new ClassSaleAssistant();
        public ClassBiz()
        {
            CollectionAccess = new ObservableCollection<ClassAccess>(getData.Access.ToList() as List<ClassAccess>);
            CollectionCountry = new ObservableCollection<ClassCountry>(getData.Country.ToList() as List<ClassCountry>);            
            User = new ObservableCollection<ClassUser>(getData.User.ToList() as List<ClassUser>);
            suppliers = new ObservableCollection<ClassSupllier>(getData.Supplier.ToList() as List<ClassSupllier>);
            getGrainRates();
            getData.Dispose();
        }

        private ObservableCollection<ClassGrainSort> _grainSort;

        public ObservableCollection<ClassGrainSort> CollectionGrainSort
        {
            get { return _grainSort; }
            set { _grainSort = value; }
        }

        private ClassSaleAssistant _classSaleAssistant;

        public ClassSaleAssistant ClassSaleAssistant
        {
            get { return _classSaleAssistant; }
            set
            {
                if (value != _classSaleAssistant)
                {
                    _classSaleAssistant = value;
                    Notify("ClassSaleAssistant");


                }
                
            }
        }

        private ObservableCollection<ClassSupllier> _suplliers;

        public ObservableCollection<ClassSupllier> suppliers
        {
            get { return _suplliers; }
            set
            {                          
                    _suplliers = value;     
            }
        }

        private ClassSupllier _classSupllier;

        public ClassSupllier ClassSupllier
        {
            get { return _classSupllier; }
            set
            {
                if (value != _classSupllier)
                {
                    _classSupllier = value;
                    Notify("ClassSupllier");
                }
                
            }
        }


        private ClassGrainSort _classGrainSort;

        public ClassGrainSort classGrainSort
        {
            get { return _classGrainSort; }
            set { _classGrainSort = value; }
        }
        private ClassCountry _classCountry;

        public ClassCountry ClassCountry
        {
            get { return _classCountry; }
            set { _classCountry = value; }
        }
        private ObservableCollection<ClassCountry> _country;

        public ObservableCollection<ClassCountry> CollectionCountry
        {
            get { return _country; }
            set { _country = value; }
        }

        private ObservableCollection<ClassAccess> _access;

        public ObservableCollection<ClassAccess> CollectionAccess
        {
            get { return _access; }
            set { _access = value; }
        }


        private ClassAccess _classAcces;

        public ClassAccess Access
        {
            get { return _classAcces; }
            set { _classAcces = value; }
        }

        private ClassUser _classUser;

        public ClassUser classUser
        {
            get { return _classUser; }
            set { _classUser = value; }
        }

        

        private ObservableCollection<ClassUser> _user;

        /// <summary>
        /// Gets and sets the collection of User
        /// </summary>
        public ObservableCollection<ClassUser> User
        {
            get => _user;
            set => _user = value;
        }

        public void MakeDataBase()
        {
            try
            {
                using (var ctx = new GrainContext())
                {
                    if (ctx.Database.Exists())
                        return;
                    else
                        ctx.Database.Create();
                   
                }
            }
            catch (DbEntityValidationException ex)
            {
                foreach (var t in ex.EntityValidationErrors)
                {
                    MessageBox.Show(t.ValidationErrors.First().ErrorMessage);
                }
            }
        }

        public void CreateSupplier()
        {
            using(var ctx = new GrainContext())
            {
                ctx.Supplier.Add(classSupllierEdit);
                ctx.SaveChanges();
                suppliers.Clear();
                List<ClassSupllier> classSuplliers = ctx.Supplier.ToList() as List<ClassSupllier>;
                foreach (ClassSupllier sup in classSuplliers)
                {
                    suppliers.Add(sup);
                }
            }
        }
        public void getGrainRates()
        {

            ClassGrainSort CGS = new ClassGrainSort();
            string data = AC.StartClient().Replace("<EOF>", "");
            string[] strArr1 = data.Split(';');
            foreach (string item in strArr1)
            {
                string[] strArr2 = item.Split(':');
                switch (strArr2[0])
                {
                    case "Oats":
                        CGS.GrainSort = strArr2[0];
                        CGS.Price = Convert.ToDecimal(strArr2[1]);
                        break;
                    case "Barley":
                        CGS.GrainSort = strArr2[0];
                        CGS.Price = Convert.ToDecimal(strArr2[1]);
                        break;
                    case "Wheat":
                        CGS.GrainSort = strArr2[0];
                        CGS.Price = Convert.ToDecimal(strArr2[1]);
                        break;
                    case "Millet":
                        CGS.GrainSort = strArr2[0];
                        CGS.Price = Convert.ToDecimal(strArr2[1]);
                        break;
                    case "Corn":
                        CGS.GrainSort = strArr2[0];
                        CGS.Price = Convert.ToDecimal(strArr2[1]);
                        break;
                    case "Rice":
                        CGS.GrainSort = strArr2[0];
                        CGS.Price = Convert.ToDecimal(strArr2[1]);
                        break;
                    default:
                        break;
                }


            }


        }
        public void SetSupplierData(object inObj)
        {
            ListView LV = (ListView)inObj;
            if (LV.SelectedItem != null)
            {
                ClassSupllier = (ClassSupllier)LV.SelectedItem;

            }
        }

    }
}
