var numbers = [];

function addNumbersToArray(){
    var inputValue = document.getElementById("caixadetexto").value;
    if(!inputValue){
        alert('O campo esta vazio!')
    }else{
        numbers.push(inputValue);
        document.getElementById("numbers").textContent = numbers.toString();
        document.getElementById("caixadetexto").value = "";
        document.getElementById("caixadetexto").focus();


    }
}


function calculateBigger(){
    if(numbers.length >= 5){
        document.getElementById("bigNumber").textContent = Math.max.apply(Math, numbers);
    }else{
        alert('Não é possivel calcular!');
    }
}


var input = document.getElementById("caixadetexto");
input.addEventListener("keyup", function(event) {
    if (event.keyCode === 13) {
        event.preventDefault();
        addNumbersToArray();
    }
});