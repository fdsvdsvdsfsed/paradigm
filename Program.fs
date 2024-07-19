// For more information see https://aka.ms/fsharp-console-apps
// Define the function to calculate the product of odd numbers
let productOfOdds (n: int) =
    // Define the tail-recursive helper function
    let rec helper (current: int) (acc: int) =
        if current < 1 then
            acc
        else
            // Tail-recursive call
            helper (current - 2) (acc * current)
    // Call the helper function with initial values
    helper n 1

// Example usage
[<EntryPoint>]
let main argv =
    let number = 11
    let result = productOfOdds number
    printfn "The product of all odd numbers from %d to 1 is %d" number result
    0 // return an integer exit code
