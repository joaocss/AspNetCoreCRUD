﻿@{
    ViewData["Title"] = "Listagem";
}

< div class = "text-center" >



    < h1 class= "display-4" > Cadatrar Contato </ h1 >

    </ div >
    < form >
  < div class= "form-group" >
    < label for= "Nome" > Nome Completo </ label >
    < input type = "text" class= "form-control" placeholder = "Escreva seu Nome" >
  </ div >

  < div >

      < label for= "Email" > Digite o Emial </ label >
    < input type = "email" class= "form-control" placeholder = " Email" >
  </ div >


    < div >

      < label for= "Celular" > Digite o Celular </ label >
    < input type = "text" class= "form-control" placeholder = " Celular" >
  </ div >
  < button type = "submit" class= "btn btn-primary" > Adicionar </ button >
  < a class= "btn btn-secondary" asp - controller = "CadastroC" asp - action = "index" role = "button" > Voltar </ a >
</ form >





