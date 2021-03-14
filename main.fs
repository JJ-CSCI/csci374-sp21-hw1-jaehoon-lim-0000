module Assignment

// Problem 1
let rec tribn n =
    // write your code here
    if n <= 0 then 0
    else if n = 1 then 1
    else if n = 2 then 1
    else tribn (n-1) + tribn (n-2) + tribn (n-3) 
// Problem 2
let tribn2 n = 
  if n <= 0 then 0
  else if n = 1 then 1
  else if n = 2 then 1
  else  let result = tribn n::tribn (n-1)::tribn (n-2)::[]
        if n > 3
        then List.head result 
        else List.head result
  
  

    // write your code here
     


// Problem 3
let rec last lst =
    // write your code here
    if List.tail lst = []
    then List.head lst
    else last(List.tail lst)

// Problem 4
let fourth (lst:int list) =
   
   if List.isEmpty lst 
   then 0
   else 
        let a = List.tail lst
        if List.tail a = [] then 0
        else
            let a = List.tail lst
            let b = List.tail a
            let c = List.tail b
            List.head c
   
  
   
  
// Problem 5
let everyfourth (lst:int list) =
    // write your code here
  
   if List.isEmpty lst 
   then []
   else 
        let a = List.tail lst
        let b = List.tail a
        if List.tail b = [] then []        
           else
            let a = List.tail lst
            let b = List.tail a
            let c = List.tail b
            let d = List.tail c
            let e = List.tail d
            let f = List.tail e
            let g = List.tail f
            let h = List.tail g
            let i = List.tail h
            let j = List.tail i
            let k = List.tail j
            let z = List.head c::List.head g::List.head k::[]
            z
            
                
         

// Problem 6
let rec take n (lst:int list) =
    // write your code here
    if List.isEmpty lst
    then []
    else if n<=10 && n >0
    then List.head lst::take (n-1) (List.tail lst)
    else if n>10
    then lst
    else []
    
  // Problem 7
let rec drop n (lst:int list) =
    if List.isEmpty lst
    then []
    else if n<=10 && n > 0
    then drop (n-1) (List.tail lst)
    else if  n = 0 
    then lst
    else []
    // write your code here
    
