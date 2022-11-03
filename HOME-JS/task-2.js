const names = ["Metin", "Mireli", "Mehemmed", "Mahir", "Fazil", "Ferahim"];
let count = 0;
let name;

for(let i = 0; i < names.length; i++){
    if(names[i].length > 5){
        console.log("Names: ", names[i]);
        count++;
    }
}
console.log("Count: ",count);