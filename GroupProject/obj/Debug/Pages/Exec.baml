   M S B A M L   `   `   `  ����G  CGroupProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:GroupProject.PagesGroupProject.Pages  5          GroupProject.Pages.Exec   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      2local clr-namespace:GroupProject.Pages     5      -   5        .��5	      � .+�5   
   � -   5          �Name$
  Main��5      $��
10,0,10,10q�6   .+�5      �� -   5         ��Name$@ :___GroupProject_component_Final_logo_for_group_project_jpg��5      $��Right=�6X   $��139.667��6t   $>��8/GroupProject;component/Final_logo_for_group_project.jpg��6�   $
��Fill=�6�   $	��Top=�6�   $��183.333��6�   �� 5      -   5         ��Name$ Logout_Button��5      $��Logout��6,   $
��Left=�6=   $��48.667��6X   $	��Top=�6h   $��140.111��6�   $��22(�6�   6�   �� 5      -   5        $ Admin_Button��5      $��Admin��6+   $
��Left=�6;   $��43.784��6V   $��Bottom=�6f   $��140.111��6�   $��24(�6�   6�   �� 5      -   5         ��Name$ SupplierListBox��5      $
��Left=�60   $��56��6K   $��58,83.667,0,0q�6W   $	��Top=�6n   $��233.667��6�    �� 
IsEditable . $��1,1,1,0q�6�   6�   &   System.Windows.Controls.DataGrid  5      -   5          Name$ SupplierData��5      $��90,166,206,145.216q�6-    �� SelectedIndex$ 2��6I      
IsReadOnly . 6[   �� 5      -   5        $ Update��5      $��Update supplier Table��6%   $
��Left=�6E   $��46��6`   $��0,0,0,72.216q�6l   $��Bottom=�6�   $	��243��6�   $��22(�6�   {�.  6�   �� 5      -	   5        $ button_Copy��5      $��Add a Supplier��6*   $��46��6C   $��273,0,267,72.216q�6O   $��Bottom=�6i   $��22(�6�   6�   �� 5      -
   5        $ Delete_Button��5      $��Delete a Supplier��6,   $��46��6H   $��0,0,0,72.216q�6T   $��Bottom=�6j   $��22(�6�   $��Right=�6�   $	��217��6�   {�.  6�   �� 5      -   5        $ Cancel_Button��5      $��Cancel��6,   $��43.784��6=   $��273,0,329,-0.83q�6M   $��Bottom=�6f   $��22(�6�   {�.  6�   �� 5      -   5        $ Submit_Button��5      $��Submit��6,   $��Right=�6=   $��43.784��6Y   $��Bottom=�6i   $	��160��6�   $��22(�6�   {�.  6�   5      � 5   
   -   5        $  NewSupplier��5      $y�	Collapsed=�6$   .+�5      � 
���   � J� Opacity$	 0.5Q�6&   �� 5      $	��250��5      
��� ���
���   �$��1q�5       	 �� CornerRadius$	 	0,55,0,55��5!      $��Center=�5"      $��Center=�5#      ._�5$      �� .+�5%      �� $��5q�6    $��Supplier Name:��6+   $
��Bold"�6A   $��Cambria)�6S   �� 5&      -   5        
 ��Name$
 SupplierTextBox��5&   e   $	��150��6   $��Center=�6-   $��Center=�6J   6e   �� 5'      $��5q�6    $��Supplier Postal:��6+   $
��Bold"�6C   $��Cambria)�6U   �� 5(      -   5        $
 PostalTextBox��5(   e   $	��150��6   $��Center=�6-   $��Center=�6J   6e   �� 5)      $��5q�6    $��Supplier location:��6+   $
��Bold"�6E   $��Cambria)�6W   �� 5*      -   5        $
 locationTextBox��5*   e   $	��150��6   $��Center=�6-   $��Center=�6J   6e   �� 5+      $��5q�6    $��Supplier Country:��6+   $
��Bold"�6D   $��Cambria)�6V   �� 5,      -   5        $
 CountryTextBox��5,   e   $	��150��6   $��Center=�6-   $��Center=�6J   6e   �� 5-      $��5q�6    $��Supplier Delivery:��6+   $
��Bold"�6E   $��Cambria)�6W   �� 5.      -   5        $
 DeliveryTextBox��5.   e   $	��150��6   $��Center=�6-   $��Center=�6J   6e   �� 5/       �� Orientation$ 
Horizontal=�6!   $��Center=�6:   .+�50      �� -   5        $ NoButton��50   !   $��5q�63   $��Cancel��6>   ��6O   Z� 6e   �� 51      -   5        $ 	YesButton��51   !   $��5q�64   $��Submit��6?   ��6P   Z� 6f   52      53      54      55      56      57      