// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.

#if INTERACTIVE
      #r @"../packages/MathNet.Numerics.FSharp/lib/net40/MathNet.Numerics.FSharp.dll"
      #r @"../packages/MathNet.Numerics/lib/net40/MathNet.Numerics.dll"

#endif

open MathNet.Numerics.LinearAlgebra
open MathNet.Numerics.LinearAlgebra.MatrixExtensions
open MathNet.Numerics.LinearAlgebra.Double
open System

[<EntryPoint>]
let main argv = 
    let vec = DenseVector([| 1.0; 2.0; 3.0; 4.0 |])
    let mat = matrix [[ 1.0; 0.0 ]
                      [ 0.0; 0.0 ]]

    Console.WriteLine(vec)
    Console.WriteLine(mat)
    printfn "%A" argv
    0 // return an integer exit code
