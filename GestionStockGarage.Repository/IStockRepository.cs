using System;
using System.Collections.Generic;
using GestionStockGarage.Models;

namespace GestionStockGarage.Repository
{
    public interface IStockRepository
    {
        public List<Piece> GetPieces();
        public void AddPiece(Piece piece);
        public Piece GetPiece(Guid id);
        public List<Piece> RemovePiece(Piece piece);
        public void InitStock(List<Piece> inventaire);
        public void ChangePiece(Piece piece);
    }
}
