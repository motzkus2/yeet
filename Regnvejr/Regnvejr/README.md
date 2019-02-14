# Regnvejrs måleværdier

## Oversigt

Meningen med dette program er at indtaste måleværdier for 7 dage, hvor man efterfølgende bliver tilbudt 3 valg til de indtastede måleværdier. Man kan bede om gennemsnit, maksimum, eller minimum som så bliver vist.

## Programmet

Programmet er lavet som en **Console App** der først udskriver nogle **Console WriteLines** der fortæller hvad man skal gøre. 
Værdierne for hver dag bliver gemt ved brug af en **Console ReadLine**, som så bliver gemt i et **Array**.
Efter man har indtastet værdierne vælger man ved brug af en **SwitchCase**, hvilken metode man vil bruge til at få vist enten
gennemsnit, maksimum, eller minimum, som så henter metoden og udskriver resultatet.

## Metoderne:

### Gennemsnit:
Gennemsnits metoden tager imod et Array hvor den efterfølgende bruger den indbyggede Array-metode "**Average**" som 
overfører resultatet over i en double og sender det tilbage. 

### Maksimum:
Maksimums metoden tager imod et Array hvor den efterfølgende bruger den indbyggede Array-metode "**Max**" som 
overfører resultatet over i en double og sender det tilbage. 

### Minimum:
Minimums metoden tager imod et Array hvor den efterfølgende bruger den indbyggede Array-metode "**Min**" som 
overfører resultatet over i en double og sender det tilbage. 