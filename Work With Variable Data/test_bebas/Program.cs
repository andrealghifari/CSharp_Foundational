char[] spinChars = { '|', '/', '-', '\\' };
        
        // Loop infinitely to create spinning animation
        int index = 0;
        while (true)
        {
            // Print the spinning character
            Console.Write("\r" + spinChars[index]);
            Thread.Sleep(100); // Adjust the speed of animation by changing the sleep duration
            
            // Move to the next character
            index = (index + 1) % spinChars.Length;
        }