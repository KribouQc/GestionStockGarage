using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using GestionStockGarage.Models;

namespace GestionStockGarage.Repository
{
    public class StockJson:IStockRepository
    {
        private List<Piece> stock;
        private string nomFichier = "piece.json";

        public StockJson()
        {
            stock = new();
            

            if (File.Exists(nomFichier))
            {
                var stringFile = File.ReadAllText(nomFichier);
                stock = JsonSerializer.Deserialize<List<Piece>>(stringFile);
                
            }
        }

        public void AddPiece(Piece piece)
        {
            stock.Add(piece);
            string stringJson = JsonSerializer.Serialize<List<Piece>>(stock);
            File.WriteAllText(nomFichier, stringJson);
        }

        public void ChangePiece(Piece piece)
        {
            var oldPiece = stock.FirstOrDefault(p => p.Id == piece.Id);
            oldPiece = piece;
            string stringJson = JsonSerializer.Serialize<List<Piece>>(stock);
            File.WriteAllText(nomFichier, stringJson);

        }

        public Piece GetPiece(Guid id)
        {
            return stock.FirstOrDefault(p => p.Id == id);
        }



        public List<Piece> GetPieces()
        {
            return stock;
        }

        public void InitStock(List<Piece> inventaire)
        {
           
            string stringJson = JsonSerializer.Serialize<List<Piece>>(inventaire);
            File.WriteAllText( nomFichier, stringJson);
            //reiniti de stock
            stock = JsonSerializer.Deserialize<List<Piece>>(stringJson);

        }

        public List<Piece> RemovePiece(Piece piece)
        {
            stock.Remove(piece);
            return stock;
        }
    }
}
