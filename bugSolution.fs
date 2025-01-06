let add x y = 
    x + y

let x = 10
let y = 20

let result = add x y
printf "%A" result // Output: 30

let x2 = 15 //Creating a new variable instead of modifying existing one
let result2 = add x2 y
printf "%A" result2 // Output: 35
