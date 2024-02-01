using Domain;
using System.Net.Http.Json;

using (var httpClient = new HttpClient())
{
    var character = new Character(
        name: "Ferb",
        description: "Ferb",
        category: Character.enumCategory.Phineas_and_Ferb,
        silhouetteJson: @"
                            .7:               ......                                 
                             JJ!.      .:^~77????????777~^:.                         
                             ?JJJ^.:~!??JJJJ????????JJ77!77~.                        
                    ....:::..?J??J?JJJ??????????????JJ7!^.                           
                    ^7?JJJJ??J?????????????????????????JJJ?!:                        
                      .:^!?J???????????????????????????????JJ7.                      
                         ^?J?????????????????????????????????JJ:                     
                       :?JJJJ?J????J??J???????????????????????J?                     
                      ~YJ?!^?7J?J?7~~~!!7?J?J?!!77??JJJ????????J~                    
                     !Y!:   7J?7~^^^^^^^^~~7?J7^^^^~?~!?JJ??????J                    
                     ^.     7!~^^^^^^^^^^^^^^!7~^^^~7  .^!?JJ???J:                   
                            ?~^^^^^^^^^^^^^^^^~!!77?7.    .^!?J?J!                   
                            !~^^^^^^^^^^^^^^7?7~::::^!?!     .^7J?                   
                            ~~^^^^^^^^^^^^~J!.         ~J:      .^                   
                            !!^^^^^^~!!7775~            .5:                          
                            !!^^^^7?!^::::^~!~.          ^Y                          
                            ^!^^~J~          ^?^          5.                         
                            ^!^^Y^            .Y.         Y:                         
                            ~7^!Y              ?~        .5                          
                            :7^~5        .?Y7  J: .77:   7?                          
                            :7^^?7       ^@@#:!J..5@@P..!Y...                        
                            :7^^^7?^.     :~!??~~~~~~~~~!~~!!~~^                     
                            :7^^^^~777!!!!777~^^^^^^^^^^^^^^^^^!7                    
                         .::^7^^^^^^^^~~~~^^^^^^^^^^^^^^^^^^^^^^7:                   
                        ^!~~!!^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^!^                   
                        7~^!7!^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^7^                   
                        ^7!7~^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^7:                   
                         .^~!7^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^7.                   
                             ?~^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^~7                    
                             7~^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^~~7^                    
                             ~~^^^^^^^^^^^^^^^^~!~~!!~~~!~~~~~^.                     
                             !!^^^^^^^^^^^^^^^^!!  ......                            
                             !!^^^^^^^^^^^^^^^^!^                                    
                             ^!^^^^^^^^^^^^^^^^7:                                    
                             ^!^^^^^^^^^^^^^^^^7.                                    
                             ~7^^^^^^^^^^^^^^^~7                                     
                             ^7^^^^^^^^^^^^^^^~7                                     
                             :7^^^^^^^^^^^^^^^^7.                                    
                             :7^^^^^^^^^^^^~!!!77.                                   
                             :7^^^^^^^^^^^^^^^7:                                     
                             .7^^^^^^^^^^^^^^~7                                      
                             .7^^^^^^^^^^^^^^~!                                      
                             .?^^^^^^^^^^^^^^!~                                      
                             .7~^^^^^^^^^^^^^7^                                      
                         .75?!7!77777!!77!777?!~~?Y^                                 
                           :JJ~.     .~77~.    .7?^                                  
                            J7^77^.^77^.:~7!:.?J:                                    
                          :7?:..:~7!:.!7~7~:77J?.                                    
                        ^?7:..........?7:7?... ~?!.                                  
                      :J7:.....~.......:^: ...~. ~J!.                                
                     !J:......^GJJJJJJJ?:~JJJJPYJ?:~J~.                              
                   .Y5^:......PGGGPGGGGGGGGPPGPGB!. :5!                              
                   :P?!??!^. YBGPPGPPGGGGGGPGPGB^ .!J^                               
                    .7?7^7J7?BB5??GGGP???PBGG?YG:!J!                                 
                      7~^7?YBPGGPPBPGG5PPGGPGPPB?!7:                                 
                     :7^~7^#PPPPPPPPPPPPPPPPPPGB!^~7                                 
                     !!^!~:BPPPPPPPPPPPPPPPPPPPB?^^7:                                
                    .7~^7.:BPPPPPPPPPPPPPPPPPPG5!~^!~                                
                    :7^~7 ^BPPPPPPPPPPPPPPPPPPGY:7^~!                                
                    ~!^!! ^BPPPPPPPPPPPPPPPPPPG5.7^~7                                
                    !~^7^ ^BPPPPPPPPPPPPPPPPPPG5.?^~7                                
                    7~^7: ^BPPPPPPPPPPPPPPPPPPG5 7^~7                                
                    ?~^?: ^#PPPPPPPPPPPPPPPPPPGJ.7^~7                                
                    7^^?: ^#PPPPPPPPPPPPPPPPPPB?:7^~!                                
                   .7^^7. ^#PPPPPPPPPPPPPPPPPPB?^!^7^                                
                   ^7^^!~:^#PPPPPPPPPPPPPPPPPPB?!~^7.                                
                  ^7~^~!!7?#PPPPPPPPPPPPPPPP5J?7~^~7                                 
                  7!7!!7 ..JBPPPPPPPPPPPPPP5J??^~~~!~                                
                  777?77    7BPPPPPPPPPPPGPPPP?!J!J!7.                               
                  ..:^^:    .BPPPG555555YJGGPPY!~?!!7:                               
                            ~BPPPB.       JGPPB! :  .                                
                            ?BPPGP        JBPPB?                                     
                            YGPPB?        JBPPGY                                     
                          .!GBGGBY^      ^5BGGBG:                                    
                          !#GPPPPBP      GGPPPPB5                                    
                          :JYYP55J~      !55P5YJ^                                    
                              ~77.        !!!                                        
                               JJY:      .YJ7                                        
                     .^7J5PPGGG#BPJ!    ^?GPGYYYYJ?7~:                               
                   .?J!!G@@@#BP5J??^    !55PB#&@@@@Y~??                              
                   YJ!777?777!!~^.        ^!7777?J?77YJ                              
                   :^^^^^^::.                ..:^^:^^.                               

");

    var response = await httpClient.PostAsJsonAsync("http://localhost:5041/api/characters", character);

    if (response.IsSuccessStatusCode)
        Console.WriteLine($"Desenho salvo com sucesso! \n {response.Content}");

    else
        Console.WriteLine($"Erro ao salvar o desenho. Código: {response.StatusCode}");
}