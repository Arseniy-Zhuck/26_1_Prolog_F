// Learn more about F# at http://fsharp.net
// See the 'F# Tutorial' project for more help.
let p1_1 x y =
        if x>y then x
        else y


[<EntryPoint>]
let main argv =
    
    let b = System.Convert.ToInt32(System.Console.ReadLine())
    let c = System.Convert.ToInt32(System.Console.ReadLine())
     
    let A = p1_1 b c
    System.Console.Write(A)
    let z = System.Console.ReadKey()
     
    
    0 // return an integer exit code
