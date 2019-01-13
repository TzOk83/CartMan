# CartMan
ROM Images Manipultation Programm for Cartridges

This is an early alpha version experimental build. Very little sanity checks are done upon working on ROM images, yet the program itself is fully functional now.

You may use this program to:
- split a 16-bit ROM image into 2 parts (Hi/Lo Even/Odd) for burning into 8-bit EPROMs.
- merge a 2x8-bit image into a 16-bit BIN file.
- do a bytwswap in 16-bit ROM image (i.e. for 68k ROMs).
- Make a multicart (with a fixed "slot" size).
- Split a multipart image into original (separate) fixed size ROMs.

Nomenclature used in program is for Little Endian (e.g. x86), if ROMs are about to be used in a Big Endian machine (e.g. MC68000 - Atari ST, Amiga, Neo Geo) L/H (O/E) parts should be swapped.
