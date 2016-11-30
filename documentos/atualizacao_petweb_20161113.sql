use petweb;


alter table animal drop column data_cadastro;
alter table animal add data_cadastro datetime null;

alter table animal_cliente drop column data_cadastro; 
alter table animal_cliente add data_cadastro datetime null;


alter table cliente drop column data_cadastro ;
alter table cliente add data_cadastro datetime null;

alter table cor drop column data_cadastro ;
alter table cor add data_cadastro datetime null;



alter table cor_animal drop column data_cadastro ;
alter table cor_animal add data_cadastro datetime null;


alter table doenca drop column data_cadastro ;
alter table doenca add data_cadastro datetime null;


alter table dose drop column data_cadastro; 
alter table dose add data_cadastro datetime null;


alter table especie drop column data_cadastro; 
alter table especie add data_cadastro datetime null;

alter table periodicidade drop column data_cadastro; 
alter table periodicidade add data_cadastro datetime null;


alter table permissao drop column data_cadastro; 
alter table permissao add data_cadastro datetime null;

alter table raca drop column data_cadastro; 
alter table raca add data_cadastro datetime null;


alter table raca_animal drop column data_cadastro; 
alter table raca_animal add data_cadastro datetime null;


alter table usuario drop column data_cadastro; 
alter table usuario add data_cadastro datetime null;


alter table usuario_permissao drop column data_cadastro; 
alter table usuario_permissao add data_cadastro datetime null;



alter table vacina drop column data_cadastro; 
alter table vacina add data_cadastro datetime null;


alter table vacina_doenca drop column data_cadastro; 
alter table vacina_doenca add data_cadastro datetime null;


alter table vacina_especie drop column data_cadastro; 
alter table vacina_especie add data_cadastro datetime null;


alter table vacina_periodicidade drop column data_cadastro; 
alter table vacina_periodicidade add data_cadastro datetime null;


alter table vacinacao drop column data_vacinacao; 
alter table vacinacao add data_vacinacao datetime null;

alter table veterinario drop column data_cadastro; 
alter table veterinario add data_cadastro datetime null;