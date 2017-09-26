
#r @"../packages/MathNet.Numerics.FSharp/lib/net40/MathNet.Numerics.FSharp.dll"
#r @"../packages/MathNet.Numerics/lib/net40/MathNet.Numerics.dll"

open MathNet.Numerics.LinearAlgebra
open MathNet.Numerics.LinearAlgebra.MatrixExtensions
open MathNet.Numerics.LinearAlgebra.Double
open System

let vec = DenseVector([| 1.0; 2.0; 3.0; 4.0 |])
let mat = matrix [[ 1.0; 0.0 ]
                  [ 0.0; 0.0 ]]

Console.WriteLine(vec)
Console.WriteLine(mat)
