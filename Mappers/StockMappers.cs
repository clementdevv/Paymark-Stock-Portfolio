using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.DTOs.Stock;
using api.Models;

namespace api.Mappers
{
    public static class StockMappers
    {
        public static StockDto ToStockDto(this Stock stockModel) {
            return new StockDto {
                Id = stockModel.Id,
                Symbol = stockModel.Symbol, 
                CompanyName = stockModel.CompanyName,
                Industry = stockModel.Industry, 
                MarketCap = stockModel.MarketCap, 
                LastDiv = stockModel.LastDiv, 
                Purchase = stockModel.Purchase, 
                Comments = stockModel.Comments.Select(c => c.ToCommentDto()).ToList()

            };
        }
        public static Stock ToStockFromCreateDTO(this CreateStockRequestDto stockDto) {
            return new Stock {
                Symbol = stockDto.Symbol, 
                CompanyName = stockDto.CompanyName,
                Industry = stockDto.Industry, 
                MarketCap = stockDto.MarketCap, 
                LastDiv = stockDto.LastDiv, 
                Purchase = stockDto.Purchase,
                
            };
        }
    }
}