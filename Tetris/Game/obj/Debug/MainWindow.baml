   M S B A M L   `   `   `  ����?  ;Game, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:GameGame  5   	       Game.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   $localclr-namespace:Game     5   	     � Title$  
MainWindow��5   	   $
��1000��6   $
��1000��6*    � DataContext 5	         Game.Commands  5
   
    J� InputBindings 5      �� 5   
   
 �� Key$ d��6    �� CommandParameter$ d��5       �� Command 5      �� *MoveCommand+5      �� 5   
   $ a��6   $ a��5       5      �� *MoveCommand+5      �� 5   
   $ s��6   $ s��5       5      �� *MoveCommand+5      �� 5   
   $ w��6   $ w��5       5      �� *MoveCommand+5      �� 5   
   $ q��6   $ q��5       5      �� *MoveCommand+5      �� 5   
   $ Space��6   $  ��5       5      �� *MoveCommand+5      .��5       � 
�������.+�5!   
   �� -   5         ��Name$ Board��5!   S   $	��450��6   $	��900��6   
���   �$��50,42,500,42q�6=   6S   �� 5"   
   -   5        $
 Next��5"   U   $	��225��6   $	��225��6   
���   �$��505,82,270,677q�6=   6U   �� 5#   
   -   5        $ Saved��5#   T   $	��225��6   $	��225��6   
���   �$��735,82,40,677q�6=   6T   �� 5$   
   $
��Next��6   $��585,36,333,870q�6    $	��100��68   $��50��6D   $��25(�6P   �� 5%   
   $��Saved��6   $��809,36,75,870q�6!   $	��100��68   $��50��6D   $��25(�6P   �� 5&   
   $��Score:��6   $��535,356,365,546q�6"   $��25(�6;   �� 5'   
   -   5         ��Name$ Score��5'      $��618,356,57,546q�6    $��25(�68   5(      5)      