/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author Sumon
 */
public class Calculator extends javax.swing.JFrame {
    private static String action="";
    private static double num1=0;
    private static double num2=0;
    private static double result=0;
    
    
    public Calculator() {
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

        jMenuItem1 = new javax.swing.JMenuItem();
        txtArea = new javax.swing.JTextField();
        btn1 = new javax.swing.JButton();
        btn2 = new javax.swing.JButton();
        btn3 = new javax.swing.JButton();
        btn4 = new javax.swing.JButton();
        btn5 = new javax.swing.JButton();
        btn6 = new javax.swing.JButton();
        btn7 = new javax.swing.JButton();
        btn8 = new javax.swing.JButton();
        btn9 = new javax.swing.JButton();
        btn0 = new javax.swing.JButton();
        btnadd = new javax.swing.JButton();
        btnsub = new javax.swing.JButton();
        btnmul = new javax.swing.JButton();
        btndiv = new javax.swing.JButton();
        btnequal = new javax.swing.JButton();
        calms = new javax.swing.JLabel();
        btndot = new javax.swing.JButton();
        btnclear = new javax.swing.JButton();
        btnback = new javax.swing.JButton();
        btnsqrt = new javax.swing.JButton();
        btnpow = new javax.swing.JButton();
        btnpow3 = new javax.swing.JButton();
        btninverse = new javax.swing.JButton();
        btnsinh = new javax.swing.JButton();
        btncos = new javax.swing.JButton();
        btntan = new javax.swing.JButton();
        btnsin = new javax.swing.JButton();
        btncosh = new javax.swing.JButton();
        btntanh = new javax.swing.JButton();
        btnRound = new javax.swing.JButton();
        btnBinary = new javax.swing.JButton();
        btnOctal = new javax.swing.JButton();
        btnHex = new javax.swing.JButton();
        btnPI = new javax.swing.JButton();
        jButton1 = new javax.swing.JButton();

        jMenuItem1.setText("jMenuItem1");

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);

        txtArea.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                txtAreaActionPerformed(evt);
            }
        });

        btn1.setText("1");
        btn1.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btn1ActionPerformed(evt);
            }
        });

        btn2.setText("2");
        btn2.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btn2ActionPerformed(evt);
            }
        });

        btn3.setText("3");
        btn3.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btn3ActionPerformed(evt);
            }
        });

        btn4.setText("4");
        btn4.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btn4ActionPerformed(evt);
            }
        });

        btn5.setText("5");
        btn5.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btn5ActionPerformed(evt);
            }
        });

        btn6.setText("6");
        btn6.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btn6ActionPerformed(evt);
            }
        });

        btn7.setText("7");
        btn7.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btn7ActionPerformed(evt);
            }
        });

        btn8.setText("8");
        btn8.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btn8ActionPerformed(evt);
            }
        });

        btn9.setText("9");
        btn9.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btn9ActionPerformed(evt);
            }
        });

        btn0.setText("0");
        btn0.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btn0ActionPerformed(evt);
            }
        });

        btnadd.setText("+");
        btnadd.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnaddActionPerformed(evt);
            }
        });

        btnsub.setText("-");
        btnsub.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnsubActionPerformed(evt);
            }
        });

        btnmul.setText("*");
        btnmul.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnmulActionPerformed(evt);
            }
        });

        btndiv.setText("/");
        btndiv.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btndivActionPerformed(evt);
            }
        });

        btnequal.setText("=");
        btnequal.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnequalActionPerformed(evt);
            }
        });

        calms.setText("CALCULATOR");

        btndot.setText(".");
        btndot.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btndotActionPerformed(evt);
            }
        });

        btnclear.setText("CLR");
        btnclear.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnclearActionPerformed(evt);
            }
        });

        btnback.setText(">back");
        btnback.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnbackActionPerformed(evt);
            }
        });

        btnsqrt.setText("sqrt");
        btnsqrt.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnsqrtActionPerformed(evt);
            }
        });

        btnpow.setText("<html>\n\nx <sup> 2 </sup>\n</html>");
        btnpow.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnpowActionPerformed(evt);
            }
        });

        btnpow3.setText("<html>\n\nx<sup> 3</sup>\n</html>");
        btnpow3.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnpow3ActionPerformed(evt);
            }
        });

        btninverse.setText("1/x");
        btninverse.setActionCommand("<html>\n\n\nx <sup>-1</sup>\n</html>");
        btninverse.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btninverseActionPerformed(evt);
            }
        });

        btnsinh.setText("sinh");
        btnsinh.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnsinhActionPerformed(evt);
            }
        });

        btncos.setText("cos");
        btncos.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btncosActionPerformed(evt);
            }
        });

        btntan.setText("tan");
        btntan.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btntanActionPerformed(evt);
            }
        });

        btnsin.setText("sin");
        btnsin.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnsinActionPerformed(evt);
            }
        });

        btncosh.setText("cosh");
        btncosh.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btncoshActionPerformed(evt);
            }
        });

        btntanh.setText("tanh");
        btntanh.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btntanhActionPerformed(evt);
            }
        });

        btnRound.setText("Round");
        btnRound.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnRoundActionPerformed(evt);
            }
        });

        btnBinary.setText("BIN");
        btnBinary.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnBinaryActionPerformed(evt);
            }
        });

        btnOctal.setText("OCT");
        btnOctal.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnOctalActionPerformed(evt);
            }
        });

        btnHex.setText("HEX");
        btnHex.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnHexActionPerformed(evt);
            }
        });

        btnPI.setText("PI");
        btnPI.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnPIActionPerformed(evt);
            }
        });

        jButton1.setText("byvn");
        jButton1.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jButton1ActionPerformed(evt);
            }
        });

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, layout.createSequentialGroup()
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING)
                    .addGroup(layout.createSequentialGroup()
                        .addGap(0, 0, Short.MAX_VALUE)
                        .addComponent(jButton1))
                    .addGroup(javax.swing.GroupLayout.Alignment.LEADING, layout.createSequentialGroup()
                        .addGap(198, 198, 198)
                        .addComponent(calms, javax.swing.GroupLayout.PREFERRED_SIZE, 122, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addGap(0, 0, Short.MAX_VALUE))
                    .addGroup(javax.swing.GroupLayout.Alignment.LEADING, layout.createSequentialGroup()
                        .addGap(161, 161, 161)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                            .addGroup(layout.createSequentialGroup()
                                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING)
                                    .addGroup(layout.createSequentialGroup()
                                        .addComponent(btn9)
                                        .addGap(18, 18, 18)
                                        .addComponent(btn0)
                                        .addGap(18, 18, 18)
                                        .addComponent(btndiv))
                                    .addGroup(layout.createSequentialGroup()
                                        .addComponent(btn5)
                                        .addGap(18, 18, 18)
                                        .addComponent(btn6)
                                        .addGap(18, 18, 18)
                                        .addComponent(btnadd)))
                                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                                    .addGroup(layout.createSequentialGroup()
                                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                                            .addGroup(layout.createSequentialGroup()
                                                .addGap(18, 18, 18)
                                                .addComponent(btn8))
                                            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                                                .addComponent(btn4)
                                                .addComponent(btnsub)))
                                        .addGap(26, 26, 26)
                                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                                            .addGroup(layout.createSequentialGroup()
                                                .addComponent(btnback)
                                                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                                                .addComponent(btnsinh))
                                            .addGroup(layout.createSequentialGroup()
                                                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                                                    .addComponent(btnclear)
                                                    .addComponent(btndot))
                                                .addGap(18, 18, 18)
                                                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                                                    .addComponent(btntanh)
                                                    .addComponent(btncosh))))
                                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, 38, Short.MAX_VALUE))
                                    .addGroup(layout.createSequentialGroup()
                                        .addGap(18, 18, 18)
                                        .addComponent(btnsqrt)
                                        .addGap(18, 18, 18)
                                        .addComponent(btninverse)
                                        .addGap(18, 18, 18)
                                        .addComponent(btnRound)
                                        .addGap(0, 0, Short.MAX_VALUE))))
                            .addComponent(txtArea)
                            .addGroup(layout.createSequentialGroup()
                                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                                    .addGroup(layout.createSequentialGroup()
                                        .addComponent(btnBinary)
                                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                                        .addComponent(btnOctal)
                                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                                        .addComponent(btnHex)
                                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                                        .addComponent(btnPI))
                                    .addGroup(layout.createSequentialGroup()
                                        .addComponent(btnmul)
                                        .addGap(18, 18, 18)
                                        .addComponent(btnequal)
                                        .addGap(18, 18, 18)
                                        .addComponent(btn7))
                                    .addGroup(layout.createSequentialGroup()
                                        .addComponent(btn1)
                                        .addGap(18, 18, 18)
                                        .addComponent(btn2)
                                        .addGap(18, 18, 18)
                                        .addComponent(btn3))
                                    .addGroup(layout.createSequentialGroup()
                                        .addComponent(btnpow, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                                        .addComponent(btnpow3, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                                        .addComponent(btnsin)
                                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                                        .addComponent(btncos)
                                        .addGap(18, 18, 18)
                                        .addComponent(btntan)))
                                .addGap(0, 0, Short.MAX_VALUE)))))
                .addGap(127, 127, 127))
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addContainerGap()
                .addComponent(calms, javax.swing.GroupLayout.PREFERRED_SIZE, 33, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addGap(35, 35, 35)
                .addComponent(txtArea, javax.swing.GroupLayout.PREFERRED_SIZE, 29, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addGap(35, 35, 35)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(btn1)
                    .addComponent(btn2)
                    .addComponent(btn3)
                    .addComponent(btn4)
                    .addComponent(btndot)
                    .addComponent(btntanh))
                .addGap(19, 19, 19)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(btnclear)
                    .addComponent(btn8)
                    .addComponent(btnadd)
                    .addComponent(btn6)
                    .addComponent(btn5)
                    .addComponent(btncosh))
                .addGap(18, 18, 18)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(btn9)
                    .addComponent(btn0)
                    .addComponent(btndiv)
                    .addComponent(btnsub)
                    .addComponent(btnback)
                    .addComponent(btnsinh))
                .addGap(18, 18, 18)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(btn7)
                    .addComponent(btnmul)
                    .addComponent(btnsqrt)
                    .addComponent(btninverse)
                    .addComponent(btnequal)
                    .addComponent(btnRound))
                .addGap(31, 31, 31)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(btnpow, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(btnpow3, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(btncos)
                    .addComponent(btntan)
                    .addComponent(btnsin))
                .addGap(18, 18, 18)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(btnBinary)
                    .addComponent(btnOctal)
                    .addComponent(btnHex)
                    .addComponent(btnPI))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                .addComponent(jButton1)
                .addGap(39, 39, 39))
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void btn3ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btn3ActionPerformed
        // TODO add your  code here:
       //txtArea.setText(btn3.getText());
        String str=txtArea.getText()+btn3.getText();
        txtArea.setText(str);
        
    }//GEN-LAST:event_btn3ActionPerformed

    private void btn1ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btn1ActionPerformed
        // TODO add your handling code here:
       // String str=btn1.getText();
       // txtArea.setText(str);
       // txtArea.setText(btn1.getText());
        
        String str=txtArea.getText()+btn1.getText();
        txtArea.setText(str);
        
        
    }//GEN-LAST:event_btn1ActionPerformed

    private void btn2ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btn2ActionPerformed
        // TODO add your handling code here:
        //txtArea.setText(btn2.getText());
         String str=txtArea.getText()+btn2.getText();
        txtArea.setText(str);
    }//GEN-LAST:event_btn2ActionPerformed

    private void btn4ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btn4ActionPerformed
        // TODO add your handling code here:
        //txtArea.setText(btn4.getText());
         String str=txtArea.getText()+btn4.getText();
        txtArea.setText(str);
    }//GEN-LAST:event_btn4ActionPerformed

    private void btn5ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btn5ActionPerformed
        // TODO add your handling code here:
        //txtArea.setText(btn5.getText());
         String str=txtArea.getText()+btn5.getText();
        txtArea.setText(str);
    }//GEN-LAST:event_btn5ActionPerformed

    private void btn6ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btn6ActionPerformed
        // TODO add your handling code here:
       // txtArea.setText(btn6.getText());
        String str=txtArea.getText()+btn6.getText();
        txtArea.setText(str);
    }//GEN-LAST:event_btn6ActionPerformed

    private void btnaddActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnaddActionPerformed
        // TODO add your handling code here:
        action="+";
        num1=Double.valueOf(txtArea.getText());
        txtArea.setText("");
        
    }//GEN-LAST:event_btnaddActionPerformed

    private void btn8ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btn8ActionPerformed
        // TODO add your handling code here:
       // txtArea.setText(btn8.getText());
        String str=txtArea.getText()+btn8.getText();
        txtArea.setText(str);
    }//GEN-LAST:event_btn8ActionPerformed

    private void btn9ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btn9ActionPerformed
        // TODO add your handling code here:
        //txtArea.setText(btn9.getText());
         String str=txtArea.getText()+btn9.getText();
        txtArea.setText(str);
    }//GEN-LAST:event_btn9ActionPerformed

    private void btn0ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btn0ActionPerformed
        // TODO add your handling code here:
       // txtArea.setText(btn0.getText());
        String str=txtArea.getText()+btn0.getText();
        txtArea.setText(str);
    }//GEN-LAST:event_btn0ActionPerformed

    private void btndivActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btndivActionPerformed
        // TODO add your handling code here:
        action="/";
        num1=Double.valueOf(txtArea.getText());
        txtArea.setText("");
        
        
    }//GEN-LAST:event_btndivActionPerformed

    private void btnsubActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnsubActionPerformed
        // TODO add your handling code here:
        action="-";
        num1=Double.valueOf(txtArea.getText());
        txtArea.setText("");
    }//GEN-LAST:event_btnsubActionPerformed

    private void btnmulActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnmulActionPerformed
        // TODO add your handling code here:
        action="*";
        num1=Double.valueOf(txtArea.getText());
        txtArea.setText("");
        
    }//GEN-LAST:event_btnmulActionPerformed

    private void btnequalActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnequalActionPerformed
        // TODO add your handling code here:
        num2=Double.valueOf(txtArea.getText());
        
        if("+".equals(action))
        {
            result=(double)(num1+num2);
            
        }
        else if("-".equals(action))
        {
            result=(double)(num1-num2);
            
        }
        else if("*".equals(action))
        {
            result=(double)(num1*num2);
        }
        else if("/".equals(action))
        {
            result=(double)(num1/num2);
            
        }
        
        txtArea.setText(String.valueOf(result));
        
            
    }//GEN-LAST:event_btnequalActionPerformed

    private void btn7ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btn7ActionPerformed
        // TODO add your handling code here:
       // txtArea.setText(btn7.getText());
        String str=txtArea.getText()+btn7.getText();
        txtArea.setText(str);
    }//GEN-LAST:event_btn7ActionPerformed

    private void txtAreaActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_txtAreaActionPerformed
        // TODO add your handling code here:
    }//GEN-LAST:event_txtAreaActionPerformed

    private void btndotActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btndotActionPerformed
        // TODO add your handling code here:
        String str=txtArea.getText()+btndot.getText();
        txtArea.setText(str);
    }//GEN-LAST:event_btndotActionPerformed

    private void btnclearActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnclearActionPerformed
        // TODO add your handling code here:
        txtArea.setText(" ");
    }//GEN-LAST:event_btnclearActionPerformed

    private void btnbackActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnbackActionPerformed
        // TODO add your handling code here:
        String s=txtArea.getText();
        s=s.substring(0,s.length()-1);
        txtArea.setText(s);
        
    }//GEN-LAST:event_btnbackActionPerformed

    private void btnsqrtActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnsqrtActionPerformed
        // TODO add your handling code here:
        num1=Double.valueOf(txtArea.getText());
        double sqr=Math.sqrt(num1);
        txtArea.setText(String.valueOf(sqr));
        
        
        
    }//GEN-LAST:event_btnsqrtActionPerformed

    private void btnpowActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnpowActionPerformed
        // TODO add your handling code here:
        
        num1=Double.valueOf(txtArea.getText());
        double num=Math.pow(num1, 2);
        txtArea.setText(String.valueOf(num));
    }//GEN-LAST:event_btnpowActionPerformed

    private void btnpow3ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnpow3ActionPerformed
        // TODO add your handling code here:
        num1=Double.valueOf(txtArea.getText());
        double num=Math.pow(num1,3);
        txtArea.setText(String.valueOf(num));
        
    }//GEN-LAST:event_btnpow3ActionPerformed

    private void btninverseActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btninverseActionPerformed
        // TODO add your handling code here:
        num1=Double.valueOf(txtArea.getText());
        double num=(double)1/num1;
        txtArea.setText(String.valueOf(num));
        
        
    }//GEN-LAST:event_btninverseActionPerformed

    private void btnsinhActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnsinhActionPerformed
        // TODO add your handling code here:
        num1=Double.valueOf(txtArea.getText());
        result=Math.sinh(num1);
        txtArea.setText(String.valueOf(result));
        
    }//GEN-LAST:event_btnsinhActionPerformed

    private void btncosActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btncosActionPerformed
        // TODO add your handling code here:
        num1=Double.valueOf(txtArea.getText());
        result=Math.cos(num1);
        txtArea.setText(String.valueOf(result));
        
    }//GEN-LAST:event_btncosActionPerformed

    private void btntanActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btntanActionPerformed
        // TODO add your handling code here:
        num1=Double.valueOf(txtArea.getText());
        result=Math.tan(num1);
        txtArea.setText(String.valueOf(result));
    }//GEN-LAST:event_btntanActionPerformed

    private void btnsinActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnsinActionPerformed
        // TODO add your handling code here:
        num1=Double.valueOf(txtArea.getText());
        result=Math.sin(num1);
        txtArea.setText(String.valueOf(result));
    }//GEN-LAST:event_btnsinActionPerformed

    private void btncoshActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btncoshActionPerformed
        // TODO add your handling code here:
        num1=Double.valueOf(txtArea.getText());
        result=Math.cosh(num1);
        txtArea.setText(String.valueOf(result));
    }//GEN-LAST:event_btncoshActionPerformed

    private void btntanhActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btntanhActionPerformed
        // TODO add your handling code here:
        num1=Double.valueOf(txtArea.getText());
        result=Math.tanh(num1);
        txtArea.setText(String.valueOf(result));
    }//GEN-LAST:event_btntanhActionPerformed

    private void btnRoundActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnRoundActionPerformed
        // TODO add your handling code here:
        num1=Double.valueOf(txtArea.getText());
        result=Math.round(num1);
        txtArea.setText(String.valueOf(result));
        
    }//GEN-LAST:event_btnRoundActionPerformed

    private void btnBinaryActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnBinaryActionPerformed
        // TODO add your handling code here:
        int n=Integer.parseInt(txtArea.getText());
        String  s=Integer.toString(n,2);
        txtArea.setText(s);    
    }//GEN-LAST:event_btnBinaryActionPerformed

    private void btnOctalActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnOctalActionPerformed
        // TODO add your handling code here:
        int n=Integer.parseInt(txtArea.getText());
        String s=Integer.toOctalString(n);
        txtArea.setText(s);
        
    }//GEN-LAST:event_btnOctalActionPerformed

    private void btnHexActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnHexActionPerformed
        // TODO add your handling code here:
        int n=Integer.parseInt(txtArea.getText());
        String s=Integer.toHexString(n);
        txtArea.setText(s);
        
    }//GEN-LAST:event_btnHexActionPerformed

    private void btnPIActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnPIActionPerformed
        // TODO add your handling code here:
        txtArea.setText(String.valueOf(Math.PI));
    }//GEN-LAST:event_btnPIActionPerformed

    private void jButton1ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButton1ActionPerformed
        // TODO add your handling code here:
    }//GEN-LAST:event_jButton1ActionPerformed

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
            java.util.logging.Logger.getLogger(Calculator.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (InstantiationException ex) {
            java.util.logging.Logger.getLogger(Calculator.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (IllegalAccessException ex) {
            java.util.logging.Logger.getLogger(Calculator.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (javax.swing.UnsupportedLookAndFeelException ex) {
            java.util.logging.Logger.getLogger(Calculator.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        }
        //</editor-fold>

        /* Create and display the form */
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new Calculator().setVisible(true);
            }
        });
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton btn0;
    private javax.swing.JButton btn1;
    private javax.swing.JButton btn2;
    private javax.swing.JButton btn3;
    private javax.swing.JButton btn4;
    private javax.swing.JButton btn5;
    private javax.swing.JButton btn6;
    private javax.swing.JButton btn7;
    private javax.swing.JButton btn8;
    private javax.swing.JButton btn9;
    private javax.swing.JButton btnBinary;
    private javax.swing.JButton btnHex;
    private javax.swing.JButton btnOctal;
    private javax.swing.JButton btnPI;
    private javax.swing.JButton btnRound;
    private javax.swing.JButton btnadd;
    private javax.swing.JButton btnback;
    private javax.swing.JButton btnclear;
    private javax.swing.JButton btncos;
    private javax.swing.JButton btncosh;
    private javax.swing.JButton btndiv;
    private javax.swing.JButton btndot;
    private javax.swing.JButton btnequal;
    private javax.swing.JButton btninverse;
    private javax.swing.JButton btnmul;
    private javax.swing.JButton btnpow;
    private javax.swing.JButton btnpow3;
    private javax.swing.JButton btnsin;
    private javax.swing.JButton btnsinh;
    private javax.swing.JButton btnsqrt;
    private javax.swing.JButton btnsub;
    private javax.swing.JButton btntan;
    private javax.swing.JButton btntanh;
    private javax.swing.JLabel calms;
    private javax.swing.JButton jButton1;
    private javax.swing.JMenuItem jMenuItem1;
    private javax.swing.JTextField txtArea;
    // End of variables declaration//GEN-END:variables
}
