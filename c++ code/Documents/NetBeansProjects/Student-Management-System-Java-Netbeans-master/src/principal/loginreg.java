/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package principal;

import java.awt.event.KeyEvent;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import javax.swing.JOptionPane;
import java.util.Properties;


/**
 *
 * @author Natasha
 */
public class loginreg extends javax.swing.JFrame {
String gender;
    /**
     * Creates new form loginreg
     */
    public loginreg() {
       
        initComponents();
         
    }

    /**
     * This method is called from within the constructor to initialize the form.
     * WARNING: Do NOT modify this code. The content of this method is always
     * regenerated by the Form Editor.
     */
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        buttonGroup1 = new javax.swing.ButtonGroup();
        fname = new javax.swing.JTextField();
        lname = new javax.swing.JTextField();
        jLabel1 = new javax.swing.JLabel();
        jLabel2 = new javax.swing.JLabel();
        jLabel3 = new javax.swing.JLabel();
        fullname = new javax.swing.JTextField();
        jLabel4 = new javax.swing.JLabel();
        nic = new javax.swing.JTextField();
        jLabel5 = new javax.swing.JLabel();
        jLabel6 = new javax.swing.JLabel();
        Male = new javax.swing.JRadioButton();
        Female = new javax.swing.JRadioButton();
        jComboBox2 = new javax.swing.JComboBox<>();
        jLabel7 = new javax.swing.JLabel();
        dateofb = new javax.swing.JTextField();
        jLabel9 = new javax.swing.JLabel();
        mobile = new javax.swing.JTextField();
        jLabel8 = new javax.swing.JLabel();
        jPasswordField1 = new javax.swing.JPasswordField();
        jLabel10 = new javax.swing.JLabel();
        jPasswordField2 = new javax.swing.JPasswordField();
        jLabel11 = new javax.swing.JLabel();
        email = new javax.swing.JTextField();
        jButton1 = new javax.swing.JButton();
        jLabel12 = new javax.swing.JLabel();
        jLabel13 = new javax.swing.JLabel();
        username = new javax.swing.JTextField();
        jPanel1 = new javax.swing.JPanel();
        jButton2 = new javax.swing.JButton();
        jButton3 = new javax.swing.JButton();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);
        setBackground(new java.awt.Color(255, 255, 255));
        getContentPane().setLayout(new org.netbeans.lib.awtextra.AbsoluteLayout());
        getContentPane().add(fname, new org.netbeans.lib.awtextra.AbsoluteConstraints(119, 65, 241, -1));
        getContentPane().add(lname, new org.netbeans.lib.awtextra.AbsoluteConstraints(119, 103, 241, -1));

        jLabel1.setText("First name");
        getContentPane().add(jLabel1, new org.netbeans.lib.awtextra.AbsoluteConstraints(51, 71, -1, -1));

        jLabel2.setText("Last name");
        getContentPane().add(jLabel2, new org.netbeans.lib.awtextra.AbsoluteConstraints(52, 106, -1, -1));

        jLabel3.setText("Full name");
        getContentPane().add(jLabel3, new org.netbeans.lib.awtextra.AbsoluteConstraints(56, 150, -1, -1));
        getContentPane().add(fullname, new org.netbeans.lib.awtextra.AbsoluteConstraints(119, 144, 241, -1));

        jLabel4.setText("Nic");
        getContentPane().add(jLabel4, new org.netbeans.lib.awtextra.AbsoluteConstraints(87, 185, -1, -1));

        nic.addKeyListener(new java.awt.event.KeyAdapter() {
            public void keyTyped(java.awt.event.KeyEvent evt) {
                nicKeyTyped(evt);
            }
        });
        getContentPane().add(nic, new org.netbeans.lib.awtextra.AbsoluteConstraints(119, 182, 241, -1));

        jLabel5.setText("Title");
        getContentPane().add(jLabel5, new org.netbeans.lib.awtextra.AbsoluteConstraints(81, 223, -1, -1));

        jLabel6.setText("Gender");
        getContentPane().add(jLabel6, new org.netbeans.lib.awtextra.AbsoluteConstraints(66, 262, -1, -1));

        buttonGroup1.add(Male);
        Male.setText("Male");
        getContentPane().add(Male, new org.netbeans.lib.awtextra.AbsoluteConstraints(119, 258, -1, -1));

        buttonGroup1.add(Female);
        Female.setText("Female");
        getContentPane().add(Female, new org.netbeans.lib.awtextra.AbsoluteConstraints(203, 258, -1, -1));

        jComboBox2.setModel(new javax.swing.DefaultComboBoxModel<>(new String[] { "None", "Mr.", "Mrs.", "Miss." }));
        getContentPane().add(jComboBox2, new org.netbeans.lib.awtextra.AbsoluteConstraints(119, 220, 241, -1));

        jLabel7.setText("Date of birth");
        getContentPane().add(jLabel7, new org.netbeans.lib.awtextra.AbsoluteConstraints(40, 302, -1, -1));
        getContentPane().add(dateofb, new org.netbeans.lib.awtextra.AbsoluteConstraints(120, 300, 241, -1));

        jLabel9.setText("Mobile Number");
        getContentPane().add(jLabel9, new org.netbeans.lib.awtextra.AbsoluteConstraints(31, 343, -1, -1));

        mobile.addKeyListener(new java.awt.event.KeyAdapter() {
            public void keyTyped(java.awt.event.KeyEvent evt) {
                mobileKeyTyped(evt);
            }
        });
        getContentPane().add(mobile, new org.netbeans.lib.awtextra.AbsoluteConstraints(119, 340, 241, -1));

        jLabel8.setText("Password");
        getContentPane().add(jLabel8, new org.netbeans.lib.awtextra.AbsoluteConstraints(40, 470, -1, -1));

        jPasswordField1.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jPasswordField1ActionPerformed(evt);
            }
        });
        getContentPane().add(jPasswordField1, new org.netbeans.lib.awtextra.AbsoluteConstraints(120, 460, 241, -1));

        jLabel10.setText("Confirm password");
        getContentPane().add(jLabel10, new org.netbeans.lib.awtextra.AbsoluteConstraints(20, 500, -1, -1));
        getContentPane().add(jPasswordField2, new org.netbeans.lib.awtextra.AbsoluteConstraints(120, 500, 240, -1));

        jLabel11.setText("Email");
        getContentPane().add(jLabel11, new org.netbeans.lib.awtextra.AbsoluteConstraints(40, 380, -1, -1));
        getContentPane().add(email, new org.netbeans.lib.awtextra.AbsoluteConstraints(120, 380, 240, -1));

        jButton1.setText("Sign Up");
        jButton1.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jButton1ActionPerformed(evt);
            }
        });
        getContentPane().add(jButton1, new org.netbeans.lib.awtextra.AbsoluteConstraints(120, 540, -1, -1));

        jLabel12.setFont(new java.awt.Font("Tahoma", 1, 18)); // NOI18N
        jLabel12.setForeground(new java.awt.Color(0, 102, 204));
        jLabel12.setText("Login Registration Form");
        getContentPane().add(jLabel12, new org.netbeans.lib.awtextra.AbsoluteConstraints(110, 30, 250, -1));

        jLabel13.setText("User Name");
        getContentPane().add(jLabel13, new org.netbeans.lib.awtextra.AbsoluteConstraints(40, 430, -1, -1));
        getContentPane().add(username, new org.netbeans.lib.awtextra.AbsoluteConstraints(120, 420, 240, -1));

        jPanel1.setBackground(new java.awt.Color(255, 255, 255));
        jPanel1.setLayout(new org.netbeans.lib.awtextra.AbsoluteLayout());

        jButton2.setText("Clear");
        jButton2.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jButton2ActionPerformed(evt);
            }
        });
        jPanel1.add(jButton2, new org.netbeans.lib.awtextra.AbsoluteConstraints(210, 540, -1, -1));

        jButton3.setText("Back");
        jButton3.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jButton3ActionPerformed(evt);
            }
        });
        jPanel1.add(jButton3, new org.netbeans.lib.awtextra.AbsoluteConstraints(290, 540, -1, -1));

        getContentPane().add(jPanel1, new org.netbeans.lib.awtextra.AbsoluteConstraints(0, 0, 470, 580));

        setSize(new java.awt.Dimension(486, 621));
        setLocationRelativeTo(null);
    }// </editor-fold>//GEN-END:initComponents

    private void jPasswordField1ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jPasswordField1ActionPerformed
        // TODO add your handling code here:
    }//GEN-LAST:event_jPasswordField1ActionPerformed

    private void jButton1ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButton1ActionPerformed
        if (fname.getText().isEmpty()|lname.getText().isEmpty()|fullname.getText().isEmpty()|nic.getText().isEmpty()|jComboBox2.getSelectedItem().equals("None")|dateofb.getText().isEmpty()|mobile.getText().isEmpty()|email.getText().isEmpty()|username.getText().isEmpty()|jPasswordField1.getText().trim().isEmpty()|jPasswordField2.getText().trim().isEmpty()) {
            getToolkit().beep();
            JOptionPane.showMessageDialog(null,"One of the required field is empty", "ERROR",JOptionPane.ERROR_MESSAGE,null);
        }
        
  else if (!nic.getText().trim().matches("^[0-9]{9}[vVxX]$")) {
                getToolkit().beep();
                JOptionPane.showMessageDialog(null,"Invalid Nic!","ERROR",JOptionPane.ERROR_MESSAGE,null);
            }
  
        
       else if(!(jPasswordField1.getText().trim().matches("^(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z])(?=.*[@#$%^&+=])(?=\\S+$).{8,}$")))
{
     JOptionPane.showMessageDialog(null,"Invalid password, Use  8 characters which contains atleast 1 uppercase letter, One lowecase letter, a symbol and a number", "ERROR",JOptionPane.ERROR_MESSAGE,null);
}
        else{   
        try {
            Class.forName("com.microsoft.sqlserver.jdbc.SQLServerDriver");
            String url = "jdbc:sqlserver://localhost:1433;databaseName=abcuni;user=sa;password=sa123";
            Connection con = DriverManager.getConnection(url);
            String query = "INSERT INTO regform (fname,lname,fullname,nic,title,gender,dateofbirth,mobile,email) values(?,?,?,?,?,?,?,?,?)";
            PreparedStatement pst = con.prepareStatement(query);
            pst.setString(1, fname.getText());
            pst.setString(2, lname.getText());
            pst.setString(3, fullname.getText());
            pst.setString(4, nic.getText());
            pst.setString(5, jComboBox2.getSelectedItem().toString());
            if (Male.isSelected()) {
           gender="Male";
       }if (Female.isSelected()) {
           gender="Female";
       }
       pst.setString(6, gender);
       
            pst.setString(7, dateofb.getText());
            pst.setString(8, mobile.getText());
            pst.setString(9, email.getText());
            
            pst.executeUpdate();
            
            System.out.println("1");
            
            if(jPasswordField1.getText().equals(jPasswordField2.getText())){
            String query1 = "INSERT INTO Login (usertype,username,password) values(?,?,?)";
            PreparedStatement pst1 = con.prepareStatement(query1);
            pst1.setString(1, "Manager");
            pst1.setString(2, username.getText());
            pst1.setString(3, jPasswordField1.getText());
            
            System.out.println("2");
           
 
                        pst1.executeUpdate();
          
          
                        
                        System.out.println("3");
                
            
            JOptionPane.showMessageDialog(null, "Signup Successfull");
            
            }
            else
            {
                JOptionPane.showMessageDialog(null, "Password Confirmation Does not match");
            }
            
            
          

        } catch (Exception e) {
           JOptionPane.showMessageDialog(null, e);
            
        }
        }
    }//GEN-LAST:event_jButton1ActionPerformed

    private void jButton2ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButton2ActionPerformed
        fname.setText("");
    lname.setText("");
    fullname.setText("");
    nic.setText("");
    jComboBox2.setSelectedItem("None");
    
    dateofb.setText("");
    mobile.setText("");
    email.setText("");
     username.setText("");
     jPasswordField1.setText("");
     jPasswordField2.setText("");
    }//GEN-LAST:event_jButton2ActionPerformed

    private void jButton3ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButton3ActionPerformed
        Login lg= new Login();
        lg.setVisible(true);
        this.dispose();
    }//GEN-LAST:event_jButton3ActionPerformed

    private void mobileKeyTyped(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_mobileKeyTyped
        // TODO add your handling code here:
           char c=evt.getKeyChar();
        if (! (Character.isDigit(c))||c==KeyEvent.VK_BACK_SPACE||c==KeyEvent.VK_DELETE) {
            getToolkit().beep();
            evt.consume();
            
        }
        String s=mobile.getText();
            
            if (!(s.length()<10 ))
            {
            getToolkit().beep();
            evt.consume();
            }
    }//GEN-LAST:event_mobileKeyTyped

    private void nicKeyTyped(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_nicKeyTyped
           String s=nic.getText();
            
            if (!(s.length()<10 ))
            {
                
                    evt.consume();
                      getToolkit().beep();
            
            }
    }//GEN-LAST:event_nicKeyTyped

    /**
     * @param args the command line arguments
     */
    public static void main(String args[]) {
        /* Set the Nimbus look and feel */
        //<editor-fold defaultstate="collapsed" desc=" Look and feel setting code (optional) ">
        /* If Nimbus (introduced in Java SE 6) is not available, stay with the default look and feel.
         * For details see http://download.oracle.com/javase/tutorial/uiswing/lookandfeel/plaf.html 
         */
        try {
            for (javax.swing.UIManager.LookAndFeelInfo info : javax.swing.UIManager.getInstalledLookAndFeels()) {
                if ("Nimbus".equals(info.getName())) {
                    javax.swing.UIManager.setLookAndFeel(info.getClassName());
                    break;
                }
            }
        } catch (ClassNotFoundException ex) {
            java.util.logging.Logger.getLogger(loginreg.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (InstantiationException ex) {
            java.util.logging.Logger.getLogger(loginreg.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (IllegalAccessException ex) {
            java.util.logging.Logger.getLogger(loginreg.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (javax.swing.UnsupportedLookAndFeelException ex) {
            java.util.logging.Logger.getLogger(loginreg.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        }
        //</editor-fold>

        /* Create and display the form */
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new loginreg().setVisible(true);
            }
        });
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JRadioButton Female;
    private javax.swing.JRadioButton Male;
    private javax.swing.ButtonGroup buttonGroup1;
    private javax.swing.JTextField dateofb;
    private javax.swing.JTextField email;
    private javax.swing.JTextField fname;
    private javax.swing.JTextField fullname;
    private javax.swing.JButton jButton1;
    private javax.swing.JButton jButton2;
    private javax.swing.JButton jButton3;
    private javax.swing.JComboBox<String> jComboBox2;
    private javax.swing.JLabel jLabel1;
    private javax.swing.JLabel jLabel10;
    private javax.swing.JLabel jLabel11;
    private javax.swing.JLabel jLabel12;
    private javax.swing.JLabel jLabel13;
    private javax.swing.JLabel jLabel2;
    private javax.swing.JLabel jLabel3;
    private javax.swing.JLabel jLabel4;
    private javax.swing.JLabel jLabel5;
    private javax.swing.JLabel jLabel6;
    private javax.swing.JLabel jLabel7;
    private javax.swing.JLabel jLabel8;
    private javax.swing.JLabel jLabel9;
    private javax.swing.JPanel jPanel1;
    private javax.swing.JPasswordField jPasswordField1;
    private javax.swing.JPasswordField jPasswordField2;
    private javax.swing.JTextField lname;
    private javax.swing.JTextField mobile;
    private javax.swing.JTextField nic;
    private javax.swing.JTextField username;
    // End of variables declaration//GEN-END:variables
}