let mutable x = 10
let mutable y = 20

let swap x y =
    let temp = x
    x <- y
    y <- temp

swap x y
printf "%d %d" x y //This will print 20 20, which is correct

let swap2 x y = 
    let temp = !x
    x := !y
    y := temp

let x2 = ref 10
let y2 = ref 20
swap2 x2 y2 // this will work correctly
printf "%d %d" !x2 !y2