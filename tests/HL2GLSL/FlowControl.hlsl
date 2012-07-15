/*
 * Flow control shader Test.
 * by Vitor Pamplona
 */

// Main function of the fragment shader.
float4 pixelShader(float4 color : COLOR0) : COLOR { 

	int i = 0;
	int type = 0; 

	// Creating Green Color
	float4 teste = float4(0+0.5,1,40*0.5,0);
	
        // Branch: Evaluate only one side of the if 
        // statement depending on the given condition.
	branch if (teste.x+4 > 0) { 
	
		teste++;
	
	} else {
	
                // Unroll(x): Unroll the loop until it stops executing. Can optionally 
                // specify the maximum number of times the loop is to execute
	   	unroll(10) for (int i=0; i+4<10; i+=4) { 
	   	  	teste--;

                        // Stop executing the current loop (do, for, while), 
                        // update the loop conditions, and begin executing from the top of the loop. 	   	  	
	   	  	continue; 
	   	}
		   
                // Flatten: Evaluate both sides of the if statement 
                // and choose between the two resulting values.
	   	flatten if (teste.x > 0) { 
	   		
                        // Loop: Generate code that uses flow control to execute each iteration of the loop.
	   		loop for (;;) { 
	   		  	teste--;	
	   		  	
	   		  	stop; // Stop execution at the current statement and return the output.
	   		}
	   		
	   		teste--;
	   		
	   	} else {
	   	
	   		do { 

		   	  	break; // Exit the surrounding loop (do, for, while).

	   		} while (teste.x+4 > 0); 
	   	
	   		discard; // Discarte: Do not output the result of the current pixel. 
	   	
	   		// flatten 	: Compile the statement as a series of if statements, 
                        //                  each with the flatten attribute.
			// branch     : Compile the statement as a series of if statements 
                        //                  each with the branch attribute.
			// forcecase : Force a switch statement in the hardware.
			// call		 : The bodies of the individual cases in the switch will be moved into
                        //                  hardware subroutines and the switch will be a series of subroutine calls.
	   	
			forcecase switch( teste.y ) {
    			case 0: k++; return teste; 
    			case 1: return teste; 
    			case 2: t++; return teste; 
    			default: { 
    				teste++;
    				teste++;
    				teste++;
    			}
			}
	   	}
	}	
	
	return teste;  //returns always black
} 