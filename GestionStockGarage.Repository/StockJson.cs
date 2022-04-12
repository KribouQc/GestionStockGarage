using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using GestionStockGarage.Models;

namespace GestionStockGarage.Repository
{
    public class StockJson:IStockRepository
    {
        private List<Piece> stock;

        public StockJson()
        {
            stock = new();
            string nomFichier = "piece.json";

            if (File.Exists(nomFichier))
            {
                var stringFile = File.ReadAllText(nomFichier);
                stock = JsonSerializer.Deserialize<List<Piece>>(stringFile);
                
            }
        }

        public void AddPiece(Piece piece)
        {
            throw new NotImplementedException();
        }

        public Piece GetPiece(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<Piece> GetPieces()
        {
            return stock;
        }
    }
}
