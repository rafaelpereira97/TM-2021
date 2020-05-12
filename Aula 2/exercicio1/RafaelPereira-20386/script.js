function changeText(){
    var inputValue = document.getElementById("caixadetexto").value;
    if(!inputValue){
        alert('O campo esta vazio!')
    }else{
        document.getElementById("texto").textContent=inputValue;
    }
}
