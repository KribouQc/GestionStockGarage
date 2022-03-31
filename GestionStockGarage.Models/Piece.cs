using System;
using System.Collections.Generic;

namespace GestionStockGarage.Models
{
    public class Piece
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public String Designation { get; set; }
        public string Reference { get; set; }
        public decimal PrixUnitaire { get; set; }
        public int QuantiteStock { get; set; }
        public string Emplacement { get; set; }
        public List<Guid> IdVoiture { get; set; }
        public Guid IdFabricant { get; set; }

    }
}
