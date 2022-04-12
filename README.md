# DIXU

dkxce opensource free symmetric crypt algorythm (UTF8, ASCII, Win-1251)

Algorythm:
 
       // op - byte to crypt
       // initial_key = 512-bit (64 bytes) initial key
       // shared_key  = any-length shared key
       
       for (j = 0; j < initial_key.Length; j++)
          op = (op << (initial_key[j] & 0x07)) ^ initial_key[j];
          
       for (j = 0; j < shared_key.Length; j++)
          op = (op << (j % 7 + 1)) ^ shared_key[j];
