// Learn more about F# at http://fsharp.net
// See the 'F# Tutorial' project for more help.



[<EntryPoint>]
let main argv =
    
    let b = System.Convert.ToInt32(System.Console.ReadLine())
    let c = System.Convert.ToInt32(System.Console.ReadLine())
    let p1_1 x y =
        if x>y then x
        else y 
    let A = p1_1 b c
    System.Console.Write(A)
    
    let rec f n =
        if n=0 then 1
        else 
            let n1=n-1
            f n1
    let f1= f 10
    printfn "%i" f1
    let z = System.Console.ReadKey()
     
    
    0 // return an integer exit code
