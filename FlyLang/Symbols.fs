namespace FlyLang

module rec Symbols =
    type Symbol = 
        Empty
        | Character of char
        | Integer of int8
        | GlideLeft of char
        | GlideRight of char
        | GlideUp of char
        | GlideDown of char
        | Subtract of char
        | Multiply of char
        | Divide of char
        | SoftWall of char
        | LeftGuard of char
        | RightGuard of char
        | PosFilterLeft of char
        | PosFilterRight of char

    type Cell = Symbol * Symbol

    



