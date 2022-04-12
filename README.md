# DIXU

**dixu** v0.1 - dkxce simple opensource free symmetric crypt algorythm (UTF8, ASCII, Win-1251)

[Скачать exe'шник можно здесь](https://github.com/dkxce/DIXU/releases/tag/dixuv0.1) - Windows XP SP3 и выше

[Algorythm](dkxce.Crypt.DIXU.cs):
 
   Crypt:  
   
       // op - byte to crypt
       // initial_key = 512-bit (64 bytes) initial key
       // shared_key  = nonzero-length shared key
       
       for (j = 0; j < initial_key.Length; j++)
          op = (op << (initial_key[j] & 0x07)) ^ initial_key[j];
          
       for (j = 0; j < shared_key.Length; j++)
          op = (op << (j % 7 + 1)) ^ shared_key[j];
          
   Decrypt:    
   
       // op - byte to crypt
       // initial_key = 512-bit (64 bytes) initial key
       // shared_key  = nonzero-length shared key
       
       for (j = shared_key.Length - 1; j >= 0; j--)
          op = (op ^ shared_key[j]) >> (j % 7 + 1);
          
       for (j = initial_key.Length - 1; j >= 0; j--)
          op = (op ^ initial_key[j]) >> (initial_key[j] & 0x07);
   

<img src="window.png"/>
