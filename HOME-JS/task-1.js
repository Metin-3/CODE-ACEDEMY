let names = ["Metin", "Eldar", "Rauf", "Cavid", "Qadir", "Elxan"];
let count = 0;

for(let i = 0; i < names.length; i++){
    if(names[i][0] == 'E'){
        console.log(names[i]);
        count++;
    }
}

console.log("Count: ", count);
