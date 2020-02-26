using GetSlabReinfResult.DataCollector.Logic;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableTetaUI.Models
{
    public class TableTetaModel: StoreyDriftModel
    {
        public double Fx { get; set; }
        public double Fy { get; set; }
        public double Fz { get; set; }

        public double Teta_x
        {
            get
            {
                if (Fx == 0) return 0;
                if (h == 0) return 0;
                return Fz * dr_x / Fx / h;
            }
        }
        public double Teta_y
        {
            get
            {
                if (Fy == 0) return 0;
                if (h == 0) return 0;
                return Fz * dr_y / Fy / h;
            }
        }

        public static ObservableCollection<TableTetaModel> Create(Storys X, Storys Y, Storys P_tot)   
        {
            List<TableTetaModel> result = new List<TableTetaModel>();
            if (X == null) throw new ArgumentNullException(); 
            if (Y == null) throw new ArgumentNullException();
            if (P_tot == null) throw new ArgumentNullException();

            for (int i = 0; i < X.Count; i++)
            {
                result.Add(new TableTetaModel
                {
                    Id=X[i].Index,
                    StoreyName=X[i].Name,
                    h=X[i].Height,

                    dr_x = X[i].dr_x,
                    dr_y = Y[i].dr_y,
                    Fx = X[i].Fx,
                    Fy = Y[i].Fy,
                    Fz = P_tot[i].Fz,
                });
            }
            return new ObservableCollection<TableTetaModel>(result);
        }
    }

    public class StoreyModel
    {
        public int Id { get; set; }
        public string StoreyName { get; set; }
        public double h { get; set; }
    }
    public class StoreyDriftModel: StoreyModel
    {
        public double dr_x { get; set; }
        public double dr_y { get; set; }
    }
    public class TableLimitationStoreyDriftModel: StoreyDriftModel
    {
        public double vDrWith_h_X { get; set; }
        public double vDrWith_h_Y { get; set; } 
    }
    public enum CatOfObjectImportance
    {
        I_II,
        III_IV
    }
}
