﻿int a1 = 15;
int b1 = 105;
int c1 = 150;
int a2 = 45000;
int b2 = 85;
int c2 = 95;
int a3 = 6005;
int b3 = 25;
int c3 = 1125;

int max = a1;
if(b1 > max) max = b1;
if(c1 > max) max = c1;
if(a2 > max) max = a2;
if(b2 > max) max = b2;
if(c2 > max) max = c2;
if(a3 > max) max = a3;
if(b3 > max) max = b3;
if(c3 > max) max = c3;
Console.WriteLine(max);