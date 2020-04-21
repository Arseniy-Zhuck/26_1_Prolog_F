// Learn more about F# at http://fsharp.net
// See the 'F# Tutorial' project for more help.


let sum a b = 
    a+b

[<EntryPoint>]
let main argv = 
    let a = System.Convert.ToInt32(System.Console.ReadLine()) 
    let b = System.Convert.ToInt32(System.Console.ReadLine())
    let Ans = sum a b
    System.Console.Write(Ans)
    let z= System.Console.ReadKey()
    0 // return an integer exit code
