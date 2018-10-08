package org.instituto.serpis.ed;

import java.util.Scanner;

import java.math.BigDecimal;

public class Suma {

	public static void main(String[] args) {
		
		String num;
		BigDecimal bDNum1, bDNum2, suma, resta, producto, division;
		Scanner teclado = new Scanner(System.in);
		
		System.out.println("Este programa muestra distintas operaciones entre dos números.");
		System.out.println("Dime el primero:");
		
		num = teclado.nextLine();
		bDNum1 = new BigDecimal(num);
		
		System.out.println("Dime el segundo:");
		
		num = teclado.nextLine();
		bDNum2 = new BigDecimal(num);
		
		suma = bDNum1.add(bDNum2);
		System.out.println(bDNum1 + " + " + bDNum2 + " = " +suma);
		
		resta = bDNum1.subtract(bDNum2);
		System.out.println(bDNum1 + " - " + bDNum2 + " = " +resta);
		
		producto = bDNum1.multiply(bDNum2);
		System.out.println(bDNum1 + " * " + bDNum2 + " = " +producto);
		
		division = bDNum1.divide(bDNum2);
		System.out.println(bDNum1 + " / " + bDNum2 + " = " +division);
		

	}

}