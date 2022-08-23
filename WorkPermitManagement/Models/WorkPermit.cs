using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WorkPermitManagement.Models
{
    public class WorkPermit
    {
        [Key]
        public int id { get; set; }

        public String ? CODE_CONT { get; set; }
        public String ? CODE_DEM { get; set; }
        public String ? CODE_REGIME { get; set; }
        public String CODE_AVANT { get; set; }
        public String CONT_CODE_CONTRAT { get; set; }
        public int CONT_NATURE_CONTRAT { get; set; }
        public DateTime CONT_DATE_DEBUT { get; set; }
        public DateTime CONT_DATE_FIN { get; set; }
        public Double CONT_VAL_NOURRITURE { get; set; }
        public Double  CONT_VAL_LOGEMENT { get; set; }
        public DateTime CONT_DATE_RESILIATION { get; set; }
        public String CONT_CODE_ACT { get; set; }
        public String CONT_CODE_CAS_SOC { get; set; }
        public String CONT_CODE_DELEG { get; set; }
        public String CONT_CODE_SIT_MAT { get; set; }
        public DateTime ? CONT_DATE_SAISIE { get; set; }
        public String CONT_OBS { get; set; }
        public Double CONT_SALAIRE { get; set; }
        public Byte CONT_CARTE_SEJOUR { get; set; }
        public Byte CONT_EST_RESILIE { get; set; }
        public DateTime DATE_LIVRAISON { get; set; }
        public DateTime CONT_DATE_ENVOI_DR { get; set; }
        public DateTime CONT_UPDATE { get; set; }
        public String CONT_PERSONNE { get; set; }
        public String CONT_PERSONNE_L { get; set; }
        public String CONT_PASSEPORT { get; set; }
        public String CONT_NATIONALITE { get; set; }
        public String CONT_NATIONALITE_L { get; set; }
        public String CONT_FONCTION { get; set; }
        public String CONT_FONCTION_L { get; set; }
        public String CONT_CODE_ENT { get; set; }
        public String CONT_CAT_ENT { get; set; }
        public String CONT_EMPLOYEUR { get; set; }
        public String CONT_EMPLOYEUR_L { get; set; }
        public String CONT_EMPLOYEUR_ADR { get; set; }
        public String CONT_EMPLOYEUR_ADR_L { get; set; }
        public String CONT_NUM_CNSS { get; set; }
        public String CONT_ACTIVITE { get; set; }
        public String CONT_SIGNER { get; set; }
        public String CONT_SIGNER_L { get; set; }
        public String CONT_QRCODE_FR { get; set; }

        public String CONT_QRCODE_AR { get; set; }

        public int CONT_CODE_PERS { get; set; }
        public int CONT_ETAT_PAIE { get; set; }
        public int CONT_MODE_PAIE { get; set; }
        public String CONT_REF_PAIE { get; set; }

        internal object ToPagedList(int pageNumber, int pageSize)
        {
            throw new NotImplementedException();
        }

        public DateTime CONT_DATE_PAIE { get; set; }
        public int synched { get; set; }

        public String CONT_CREATED_BY { get; set; }
        public String CONT_ACTIVITE_L { get; set; }
        public String CONT_UPDATED_BY { get; set; }


    }
}
