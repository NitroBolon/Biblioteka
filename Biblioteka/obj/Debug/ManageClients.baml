   M S B A M L   `   `   `  ����E  ABiblioteka, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Biblioteka
Biblioteka  5          Biblioteka.ManageClients   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      *localclr-namespace:Biblioteka     5      -   5        .��5	      � $��50,50,50,50q�6     � RowDefinitions  5
   
   �� 5      $
��313* �6   �� 5      $	��37* �6   .+�5   
   ]� $��2��6   .+�5      ]� $	��Top=�6   $
��Left=�6-   $	��690��6H   $��
10,0,230,0q�6U   .+�5      ]� $	��Top=�6   .+�5      �� .��6   Filtrowanie6)   5      ]� 5      .+�5      ��    CustomTextBoxStyle#��[  6   $	��210��6J   $��30��6V   $��Nazwisko��6b   6t   �� 5      #��[  6   $	��210��6J   $��30��6V   $��	0,0,225,0q�6b   $
��Imie��6u   6�   5      5      ]� 5      $	��Top=�6   $��	0,0,0,-15q�6-   .+�5      �� $��Right=�6   $��10q�64   $	��180��6@   $	��201��6O   .+�5      �� .��6   Indeks6$   �� 5      -   5        $��
indexInput��5   J   #��[  6   6^   �� 5      .��6   Imię6"   �� 5      -   5        $��	nameInput��5   J   #��[  6   6]   �� 5      .��6   
Nazwisko6&   �� 5      -   5        $��surnameInput��5   J   #��[  6   6`   �� 5       .��6   	Telefon6%   �� 5!      -   5        $��
phoneInput��5!   J   #��[  6   6^   �� 5"       �� Orientation$ 
Horizontal=�6!   $��Center=�6:   $	��200��6W   .+�5#      �� -   5        $��
0,10,10,10q�5#   !     CustomButtonStyle#��[ 65   .��6u   Zapisz6}   �� 5$      $��
0,10,10,10q�6!   #��[ 66   .��6a   	Modyfikuj6l   �� 5%      -   5        $��
0,10,10,10q�5%   !   #��[ 6I   .��6t   Wyjdź6{   5&      5'      �� 5)      -   5         ��Name$ listView��5)      $��10q�6-     CustomListView#��[ 69   $	��441��6b    �� View 5*      �� 5+      .P�5,      �� $��Indeks��6-    �� Width$ 80��6=    �� DisplayMemberBinding 6H   �� *indeks+5-      �� 5.      $
��Imie��6-   $	 120��6;    6G   �� *imie+5/      �� 50      $��Nazwisko��6-   $	 140��6?    6K   �� *
nazwisko+51      �� 52      $��Telefon��6-   $ 90��6>    6I   �� *	telefon+53      55      58      59      5:      5;      5<      