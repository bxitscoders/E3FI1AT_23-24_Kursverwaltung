   M S B A M L   `   `   `  ����I  EKursverwaltung, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:Kursverwaltung.ViewsKursverwaltung.Views  5   	   +    %Kursverwaltung.Views.PersonalDataView   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:Kursverwaltung.Views     5   	     � Title$  User registrieren��5   	   $	��297��6#   $	��290��60   .��5	      � $	��309��6   $	��Top=�6   .+�5
   
   �� -   5         ��Name$ 
lblWelcome��5
      $(��"Willkommen bei der Kursverwaltung!��6$   $��center=�6Q   $��Center=�6u   $��40��6�   $��0,10,0,0q�6�   $	��Top=�6�   $	��270��6�   $��16(�6�   �� 5   
   $��Vorname:��6   $
��Left=�6#   $��	66,52,0,0q�6>   $	��Top=�6Q   $��72��6i   $��30��6t   �� 5   
   $��	Nachname:��6   $
��Left=�6$   $��	57,81,0,0q�6?   $	��Top=�6R   $��81��6j   $��30��6u   �� 5   
   $��Geburtsdatum:��6   $
��Left=�6(   $��
39,112,0,0q�6C   $	��Top=�6W   $��99��6o   $��30��6z   �� 5   
   $��E-Mail:��6   $
��Left=�6"   $��
81,142,0,0q�6=   $	��Top=�6Q   $��57��6i   $��30��6t   �� 5   
   -   5         ��Name$ txbNewUserFirstName��5      $
��Left=�6/   $��
138,56,0,0q�6J    �� TextWrapping$
 Wrap=�6^   $	��Top=�6r   $	��120��6�   $��21��6�   ��6�   ��  �� Path$ 	FirstName� �� Mode$ TwoWay=��� 5   
   -   5        $ txbNewUserLastName��5      $
��Left=�6.   $��
138,85,0,0q�6I   $
 Wrap=�6]   $	��Top=�6q   $	��120��6�   $��21��6�   ��6�   �� $ LastName�$ TwoWay=��� 5   
   -   5        $ txbNewUserBirthdate��5      $
��Left=�6/   $��138,117,0,0q�6J   $
 Wrap=�6_   $	��Top=�6s   $	��120��6�   $��21��6�   ��6�   �� $ 	Birthdate�$ TwoWay=��� 5   
   -   5        $ txbNewUserMail��5      $
��Left=�6*   $��138,147,0,0q�6E   $
 Wrap=�6Z   $	��Top=�6n   $	��120��6�   $��21��6�   ��6�   �� $ Email�$ TwoWay=��� 5   
   -   5        $ txbNewUserPW��5      $
��Left=�6(   $��138,173,0,0q�6C   $
 Wrap=�6X   $	��Top=�6l   $	��120��6�   $��21��6�   ��6�   �� $ Password�$ TwoWay=��� 5   
   -   5         ��Name$ btnNewUserRgst��5      $��Registrieren��6)   $��Center=�6@   $��	0,232,0,0q�6]   $	��Top=�6p   $��92��6�   ��6�   �� *RegisterCommand+�� 5   
   $��	Passwort:��6   $
��Left=�6$   $��
69,166,0,0q�6?   $	��Top=�6S   $��69��6k   $��30��6v   �� 5   
   -   5        $ txbNewUserPWBestätigen��5      $
��Left=�62   $��138,197,0,0q�6M   $
 Wrap=�6b   $	��Top=�6v   $	��120��6�   $��21��6�   ��6�   �� *PasswordConfirmation+�� 5   
   $��Passwort bestätigen:��6   $
��Left=�6/   $��
10,190,0,0q�6J   $	��Top=�6^   $	��128��6v   $��28��6�   5      5      