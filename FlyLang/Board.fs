 
namespace FlyLang
open FlyLang.Symbols
module Board =
    type Board =
        {
            Board: Symbol[,]
            Width : int
            Height: int
            HeightSeperator : int
            WidthSeperator : int
        }
    let create width height hsv wsv =
         {Board = (Array2D.create width height Empty); Width = width; Height = height; HeightSeperator = hsv; WidthSeperator = wsv}
    
        


