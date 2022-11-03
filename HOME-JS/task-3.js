let numbers = [7,5,7,9,0,13,5,3];
let min = numbers[0];
let temp;

for(let i = 0; i < numbers.length; i++){
    for(let j = 0; j < numbers.length -1; j++){
        if(numbers[i] > numbers[j]){
            temp = numbers[i];
            numbers[i] = numbers[j];
            numbers[j] = temp;
        }
    }
}
console.log("Numbers: ", numbers);