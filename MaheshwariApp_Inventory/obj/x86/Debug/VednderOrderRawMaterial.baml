   M S B A M L   `   `   `  ����  MaheshwariApp_Inventory5    /MaheshwariApp_Inventory.VednderOrderRawMaterial   5
      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -   5          >�Name$  orderRawMaterial��5      .��5      � 
�������.+�5   
   �� -   5        $��label1��5   1   $��50��6   $��300,0,-28,0q�6   $	��Top=�6?   $��Stretch=�6W   $��26(�6u   $��SemiBold"�6�   $��ORDER(RAW MATERIAL)��6�   $��
Lucida Fax)�6�   6�   � 5   
   $��24,65,25,24q�6   $	��800��6)   .+�5      �� $��Order ID��6   $��30��6'   $	��130��63   $��
Lucida Fax)�6?   $��12(�6W   $��5q�6e   �� 5      -   5        $��
txtOrderId��5   s   $��30��6    �� TextWrapping$
 Wrap=�6"   $	��250��66   $��2q�6B   $��12(�6M   $��
Lucida Fax)�6[   6s   �� 5      $
��Date��6   $��30��6#   $	��130��6/   $��
Lucida Fax)�6;   $��12(�6S   $��5q�6a   �� 5      -   5        $��txtOrderDate��5   s   $��30��6   $
 Wrap=�6"   $	��250��66   $��4q�6B   $��12(�6M   $��
Lucida Fax)�6[   6s   �� 5      $��	Vender ID��6   $��30��6(   $	��130��64   $��
Lucida Fax)�6@   $��12(�6X   $��5q�6f   �� 5      -   5        $��txtVenderID��5   s   $��30��6   $
 Wrap=�6"   $	��250��66   $��2q�6B   $��12(�6M   $��
Lucida Fax)�6[   6s   �� 5      $��Vender Name��6   $��30��6*   $	��130��66   $��
Lucida Fax)�6B   $��12(�6Z   $��5q�6i   �� 5      -   5        $��cmbVenderName��5   #   $��30��6   $	��244��68    �� 
IsEditable . $��10q�6V   �� 5       $��Mobile Number��6   $��30��6,   $	��130��68   $��
Lucida Fax)�6D   $��12(�6\   $��5q�6k   �� 5!      -   5        $��txtVenderMobileNo��5!   s   $��30��6   $
 Wrap=�6"   $	��250��66   $��2q�6B   $��12(�6M   $��
Lucida Fax)�6[   6s   �� 5"      $�� ��6   $��
Lucida Fax)�6   $��14(�67   $��30��6E   $	��130��6Q   $y�Hidden=�6]   $��2q�6q   �� 5#      $��30��6   $
 Wrap=�6"   $	��250��66   $y�Hidden=�6B   $��2q�6V   $��12(�6a   $��
Lucida Fax)�6o   �� 5$      $��Type Of Material��6   $��30��6/   $	��130��6;   $��
Lucida Fax)�6G   $��12(�6_   $��5q�6m   �� 5%      $��Quantity��6   $��30��6'   $	��130��63   $��
Lucida Fax)�6?   $��12(�6W   $��5q�6f   �� 5&      -   5        $��btnAddToGrid��5&   /   $	��[+]��6   $��23��6#   $��40��6C   $��5q�6N   �� 5'      -	   5        $��cmbTypeOfMaterial��5'   s   $��30��6   $
 Wrap=�6"   $	��404��66   $��2q�6B   $��12(�6M   $��
Lucida Fax)�6[   $y�Hidden=�6�   �� 5(      -
   5        $��	comboBox1��5(   #   $��30��6   $	��120��64    . $��5q�6R   �� 5)      $��30��6   $
 Wrap=�6"   $	��124��66   $��5q�6C   $��12(�6N   $��
Lucida Fax)�6\   �� 5*      $��30��6   $
 Wrap=�6"   $	��250��66   $y�Hidden=�6B   $��2q�6V   $��12(�6a   $��
Lucida Fax)�6o   &   System.Windows.Controls.DataGrid  5,      -   5        $��gdAddRawMaterial��5,   @      AutoGenerateColumns .  $	��112��63   $	��350��6X   $��5q�6d   �� 5-      -   5        $��cmbTypeOfMaterial1��5-   s   $��30��6   $
 Wrap=�6"   $	��404��66   $��2q�6B   $��12(�6M   $��
Lucida Fax)�6[   $y�Hidden=�6�   �� 5.      -   5        $��btnAdd��5.   /   $	��ADD��6   $��23��6#   $��75��6=   $��20q�6H   6T   �� 50      -   5        $��	btnUpdate��50   2   $��UPDATE��6   $��23��6&   $��75��6C   $��20q�6N   �� 51      -   5        $��	btnDelete��51   2   $��DELETE��6   $��23��6&   $��75��6C   $��20q�6N   �� 52      -   5        $��btnClear��52   1   $��CLEAR��6   $��23��6%   $��75��6A   $��20q�6L   56      57      58      