# FlyLang Design Document

By Nathan Lapp

# Table of Contents

[FlyLang Design Document 1](#_Toc87473648)

[Overview 3](#_Toc87473649)

[Symbols 3](#_Toc87473650)

[Symbol Types 4](#_Toc87473651)

[Functions 4](#_Toc87473652)

## Overview

FlyLang (Or Fly) is a self-modifying esoteric programming. The source code is made up of a grid of UTF-8 symbols. Each cell in the grid will consist of two symbols. Every frame the symbols of the board will be interpreted, and a new board will be output, which will be interpreted in the next frame.

### Symbols

Symbols can be interpreted in several different ways, as functions, character literals, integer literals. They can be combined in different ways to give new meanings, like combining two function symbols to create a new function or combining a symbol with the character literal symbol (denoted &#39;) to interpret that symbol as a character literal.

## Symbol Types

### Functions

#### Function Categories

| Name | Description |
| --- | --- |
| Gliders | Continuously moves the direction it is pointing, carrying the symbol in the adjacent Cell-spot with it. Symbols that collide with it in the direction its moving will be pushed along that direction |
| Math | When an integer is located in the adjacent cell-spot and it collides with another integer that math operation will applied to both integers, with the integer inside its cell on the left side of the expression
|+5| |7 |Will be 5 + 7 if they collide |
| Control | Controls glider-based movement based on a set of predicates. |
|
 |
 |
|
 |
 |

#### Basic functions

| Symbol name | Character | UTF-8 Code (Hexadecimal) | Category | Description |
| --- | --- | --- | --- | --- |
| Glide-Left | \&lt; | 3C | Glider | Glides left |
| Glide-Right | \&gt; | 3E | Glider | Glides right |
| Glide-Up | ^ | 5E | Glider | Glides up |
| Glide-Down | v | 76 | Glider | Glides down |
| Add | + | 2B | Math | Adds two integers |
| Subtract | - | 2D | Math | Subtract two integers |
| Multiply | \* | 2A | Math | Multiply two integers |
| Divide | / | 2F | Math | Divide two integers |
| Soft wall | | | 7C | Control | Stops glider-based movement on the side of cell its in. |
| Hard wall | || | 7C 7C | Control | Stops all gilder-based movement |
| Guard | { [x] or [x]} | 7B/7D | Control | Stops all glider-based movement if the symbol in its adjacent cell-spot is != 1. Only works if symbol collides in the direction it is pointing |
| Positive filter | ( [x] or [x]) | 28/29 | Control | Only allows glider based movement if the symbol the glider is pushing or carrying equals the one in adjacent cell spot. |
| Negative filter | [[x] or [x] ] | 5B/5D | Control | Only allows glider based movement if the symbol the glider is pushing or carrying does not equals the one in adjacent cell spot. |

| Symbol name | Character | UTF-8 Code (Hexidecimal) | Category | Description |
| --- | --- | --- | --- | --- |
| Reflector | // or \\ | 2F/5C | Control | Reflects glider based movement based on direction it is coming from and orientation |
|
 |
 |
 |
 |
 |
|
 |
 |
 |
 |
 |
|
 |
 |
 |
 |
 |
|
 |
 |
 |
 |
 |
|
 |
 |
 |
 |
 |
|
 |
 |
 |
 |
 |