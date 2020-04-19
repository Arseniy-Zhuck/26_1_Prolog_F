// Learn more about F# at http://fsharp.net
// See the 'F# Tutorial' project for more help.

let max2 x y =
    if x>y then x
    else y
let min2 x y =
    if x<y then x
    else y
let sum2 x y = x+y
let p3 f x y z =
    let f2 = f x y
    f f2 z
let p1_2 = 
    let a= System.Convert.ToInt32(System.Console.ReadLine())
    let b= System.Convert.ToInt32(System.Console.ReadLine())
    let c= System.Convert.ToInt32(System.Console.ReadLine())
    (p3 max2 a b c,p3 min2 a b c,p3 sum2 a b c)

[<EntryPoint>]
let main argv = 
    let Ans = p1_2
    System.Console.Write(Ans)
    let z = System.Console.ReadKey()        
    
    
    0 // return an integer exit code
