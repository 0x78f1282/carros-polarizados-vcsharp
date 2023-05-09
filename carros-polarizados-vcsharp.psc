Algoritmo sin_titulo
	Definir técnico, placaAutomovil Como Caracteres
	Definir anhadirTecnico, gradoPolarizado Como Entero
	anhadirTecnico = 0;
	gradoPolarizado = 0;
	Definir costoAdicional, polarizadoAnterior, costoPolarizado, descuentos, totalPagar Como Real
	costoAdicional = 0;
	polarizadoAnterior = 0;
	costoPolarizado = 0;
	descuentos = 0;
	totalPagar = 0;
	Definir  esReferido, instagram Como Entero
	esReferido = 0;
	instagram = 0;
	Escribir "============================================"
	Escribir "CONTROL DE INGRESO TRABAJOS DE POLARIZADOS"
	Escribir "============================================"
	
	Repetir
		Escribir "Ingresa el nombre del técnico: "
		Leer tecnico 
		
		Escribir "Ingresa la placa del automovil"
		Leer placaAutomovil
		
		Escribir "Selecciona el grado de polarizado:"
		Escribir "1. Grado más oscuro. $170"
		Escribir "2. Grado legal. $130"
		Escribir "3. Grado más claro. $75"
		Leer gradoPolarizado
		
		Si (gradoPolarizado < 0 Y gradoPolarizado >3)
			Escribir  "Valor incorrecto. Selecciona entre 1 y 3."
		SiNo
			
		Segun gradoPolarizado Hacer
			1:
				costoPolarizado <- 170
			2:
				costoPolarizado <- 130
			3:
				costoPolarizado <- 75
		Fin Segun
		FinSi
	
		Escribir "¿Tenias un polarizado instalado previamente?"
		Escribir "1. Sí"
		Escribir "0. No"
		Leer costoAdicional
		Si (costoAdicional < 0 Y costoAdicional >1)
			Entonces Escribir "Valor incorrecto."
			Sino
			Según (costoAdicional)
				Caso 1: polarizadoAnterior <- 10
			FinSegún
		FinSi
		
		Escribir "¿Es el cliente referido por otro cliente?"
		Escribir "1. Sí"
		Escribir "0. No"
		Leer esReferido
		
		Si(esReferido < 0 O esReferido > 1)
			Escribir  "Valores incorrectos"
		FinSi
		Según (esReferido)
			1: Descuento <- precioPolarizado * 0.05
		FinSegun
		
		Escribir "¿Es el cliente referido através de la cuenta de Instagram?"
		Escribir "1. Sí"
		Escribir "0. No"
		Leer instagram
		Si (instagram < 0 O instagram > 1)
			Escribir "Valores incorrectos"
		FinSi
		Según (instagram)
			1: instagram <- precioPolarizado * 0.02
		FinSegun
		
		//Procesamiento de datos
		descuentos = instagram + esReferido
		totalPagar = (costoPolarizado - descuentos) + polarizadoAnterior
		
		// Salida de datos
		Escribir "================================="
		Escribir "RESULTADO"
		Escribir "================================="
		Escribir "Nombre del técnico: ", tecnico
		Escribir "Grado de polarizado: ", gradoPolarizado
		Escribir "Placa automóvil: ", placaAutomovil
		Escribir "Total descuentos aplicados: ", descuentos
		Escribir "Total a pagar: ", totalPagar
		Escribir "================================="
		Escribir "FIN"
		Escribir "================================="

		
		Escribir "Quieres añadir otro trabajo?"
		Escribir "1. Sí, volver a iniciar el programa."
		Escribir "0. No, cerrar programa."
		Leer anhadirTecnico
		
		
	Hasta Que anhadirTecnico == 0
	


FinAlgoritmo
