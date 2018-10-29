package org.institutoserpis.ed;

import static org.junit.jupiter.api.Assertions.*;

import org.junit.jupiter.api.Test;

class VectorTest {

	@Test
	void indexOf() {
		int[] v = new int[] {16,12,15,14,17};
		assertEquals(0, Vector.indexOf(v, 16));
		assertEquals(2, Vector.indexOf(v, 15));
		assertEquals(4, Vector.indexOf(v, 17));
		assertEquals(-1, Vector.indexOf(v, 33));
	}
	
	@Test
	void indexOfEmpty() {
		int[] v = new int[] {};
		assertEquals(-1, Vector.indexOf(v, 22));
	}
	
	@Test
	void min() {
		assertEquals(10, Vector.min(new int[] {10,12,15,14,17}));
		assertEquals(12, Vector.min(new int[] {16,12,15,14,17}));
		assertEquals(3, Vector.min(new int[] {9,12,3,4,5}));
		assertEquals(1, Vector.min(new int[] {9,12,3,4,1}));
		assertEquals(5, Vector.min(new int[] {5}));
		assertEquals(1, Vector.min(new int[] {1,1}));
	}
	
	@Test
	void indexOfMin() {
		assertEquals(0, Vector.indexOfMin(new int[] {10,12,15,14,17}));
		assertEquals(1, Vector.indexOfMin(new int[] {16,12,15,14,17}));
		assertEquals(2, Vector.indexOfMin(new int[] {9,12,3,4,5}));
		assertEquals(4, Vector.indexOfMin(new int[] {9,12,3,4,1}));
		assertEquals(0, Vector.indexOfMin(new int[] {6}));
		assertEquals(0, Vector.indexOfMin(new int[] {1,1}));
	}

	@Test
	void sort() {
		int[] v1 = new int[] {16,12,15,14,17};
		Vector.sort(v1);
		assertArrayEquals(new int[] {12,14,15,16,17}, v1);
		
		int[] v2 = new int[] {9,12,3,4,5};
		Vector.sort(v2);
		assertArrayEquals(new int[] {3,4,5,9,12}, v2);
		
		int[] v3 = new int[] {1,2,3,4,5,6,7,8};
		Vector.sort(v3);
		assertArrayEquals(new int[] {1,2,3,4,5,6,7,8}, v3);
		
		int[] v4 = new int[] {1,1,1};
		Vector.sort(v4);
		assertArrayEquals(new int[] {1,1,1}, v4);
		
		int[] v5 = new int[] {1,3,1};
		Vector.sort(v5);
		assertArrayEquals(new int[] {1,1,3}, v5);
		
		int[] v6 = new int[] {23};
		Vector.sort(v6);
		assertArrayEquals(new int[] {23}, v6);
		
	}
	
}