   M S B A M L   `   `   `  ����I  EKursverwaltung, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:Kursverwaltung.ViewModelsKursverwaltung.ViewModels  5   	   ,    &Kursverwaltung.Views.UserAnmeldungView   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   >
ViewModels'clr-namespace:Kursverwaltung.ViewModels     5   	   $	��220��5   	   $	��320��6     � 
ResizeMode$  NoResize=�6"    � 	Resources 5      /   )Kursverwaltung.ViewModels.UserAnmeldungVM   UserAnmeldungVM��%   &	          5   
   6%   5	      .��5
      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   �� $��0��6   $��E-Mail-Adresse:��6!   $��
10,30,10,5q�68   �� 5   
   -   5         ��Name$ UserMailTextBox��5      $��1��6   $��5q�68   ��6C   �� *	UserEMail+�� 5   
   $��2��6   $��	Passwort:��6!   $��
10,10,10,5q�62   G� 5   
   -   5        $��PasswordBox��5   #   $��3��6   $��5q�66   6A   � 5   
   $��4��6   $��20,10,20,10q�6    � ColumnDefinitions 5      �� 5      $��* �6#   �� 5      $
��Auto �6#   �� 5      $��* �6#   .+�5       �� $��0��6   $��Anmelden��6%   $	��100��68   $��0,0,10,0q�6D   �� 5!      $��2��6   $��Registrieren��6%   $	��100��6<   $��10,0,0,0q�6H   5"      5#      5$      