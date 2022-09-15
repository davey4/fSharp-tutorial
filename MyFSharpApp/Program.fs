// // Learn more about F# at http://fsharp.org

open System

// [<EntryPoint>]
// let main argv =
//     printfn "Hello World from F#!"
//     0 // return an integer exit code


// Define a new function to print a name.
let printGreeting =
    printfn "Hello %s from F#!"
let myName = "Dave"
// Call your new function!
do printGreeting myName