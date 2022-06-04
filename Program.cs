﻿using EncontroRemoto4.Classes;

//PessoaFisica novaPf = new PessoaFisica();
//PessoaFisica metodosPf = new PessoaFisica();
//Endereco novoEndPf = new Endereco();

//novaPf.Nome = "Odirlei";
//novaPf.dataNasc = new DateTime (2000, 01, 01);
//novaPf.Cpf = "1234567890";
//novaPf.Rendimento = 3500.5f;

//novoEndPf.logradouro = "Alameda barao de limeira";
//novoEndPf.numero = 539;
//novoEndPf.complemento = "SENAI Informatica";
//novoEndPf.endComercial = true;

//novaPf.Endereco = novoEndPf;

//Console.WriteLine(@$"
//Nome: {novaPf.Nome}
//Endereço : {novaPf.Endereco.logradouro}, {novaPf.Endereco.numero}
//Maior de idade: {metodosPf.ValidarDataNasc(novaPf.dataNasc)}
//");

//Console.WriteLine(metodosPf.ValidarDataNasc("01/01/2000"));

//novaPf.ValidarDataNasc(novaPf.dataNasc);

//Console.WriteLine(novaPf.Nome);

//Console.WriteLine($"Nome: {novaPf.Nome} Nome: {novaPf.Nome}");
//Console.WriteLine("Nome: " + novaPf.Nome + " Nome: " + novaPf.Nome); //Com concatenação, é mais difícil a construção

PessoaJuridica novaPj = new PessoaJuridica();
PessoaJuridica metodosPj = new PessoaJuridica();
Endereco novoEndPj = new Endereco();

novaPj.Nome = "SENAI INFORMATICA LDTA";
novaPj.RazaoSocial = "Razão Social PJ";
novaPj.Cnpj = "48282715000100";
novaPj.Rendimento = 10000.5f;

novoEndPj.logradouro = "Alameda barao de limeira";
novoEndPj.numero = 539;
novoEndPj.complemento = "SENAI Informatica";
novoEndPj.endComercial = true;

novaPj.Endereco = novoEndPj;

Console.WriteLine(@$"
Nome: {novaPj.Nome}
Razão Social : {novaPj.RazaoSocial}
Cnpj : {novaPj.Cnpj}, Válido: {metodosPj.ValidarCnpj(novaPj.Cnpj)}
Endereço : {novaPj.Endereco.logradouro}, {novaPj.Endereco.numero}
Complemento : {novaPj.Endereco.complemento}
");




