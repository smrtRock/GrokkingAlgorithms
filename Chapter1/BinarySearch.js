function binary_search(list, item) {
    var low = 0
    var high = list.length

    while (low <= high) {
        mid = Math.floor((low + high) / 2)
        guess = list[mid]
        if (guess == item)
        {
            return mid;
        }        
        else if (guess > item)
        {
            high = mid -1
        }
        else{
            low = mid + 1
        }
    }
    return null 
}

var my_list = new Array(1, 3, 5, 7, 9)
console.log(binary_search(my_list, 3))
console.log(binary_search(my_list, -1))