let mutable x = 10
let mutable y = 20

let add x y = 
    x + y

let result = add x y
printf "%A" result // Output: 30

x <- 15 //Modifying x

let result2 = add x y
printf "%A" result2 //Output:35
