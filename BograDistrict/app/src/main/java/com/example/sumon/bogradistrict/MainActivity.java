package com.example.sumon.bogradistrict;

import android.content.DialogInterface;
import android.content.Intent;
import android.support.v7.app.AlertDialog;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;

public class MainActivity extends AppCompatActivity implements View.OnClickListener {

    private Button bograButton,sadorButton,sonatolaButton,sariyakandiButton,gabtoliButton,shahjahanpurButton,kahaluButton,serpurButton,adomdighiButton,sibgonjButton,nondigramButton, dhunot,dhup;

    private Intent intent;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        bograButton=(Button)findViewById(R.id.bograButtonId);
       sadorButton= (Button)findViewById(R.id.sadorButtonId);

       sonatolaButton= (Button)findViewById(R.id.sonatolaButtonId);

       sibgonjButton= (Button)findViewById(R.id.sibgonjButtonId);

       gabtoliButton= (Button)findViewById(R.id.gabtoliButtonId);

       shahjahanpurButton= (Button)findViewById(R.id.shahjahanpurButtonId);
       kahaluButton=(Button)findViewById(R.id.kahaluButtonId);

       adomdighiButton= (Button)findViewById(R.id.adomdighiButtonId);
      sariyakandiButton=  (Button)findViewById(R.id.sariyakandiButtonId);

      serpurButton=(Button)findViewById(R.id.serpurButtonId);

      bograButton.setOnClickListener(this);
      sadorButton.setOnClickListener(this);
      sonatolaButton.setOnClickListener(this);
      sariyakandiButton.setOnClickListener(this);
      sibgonjButton.setOnClickListener(this);
      shahjahanpurButton.setOnClickListener(this);
      gabtoliButton.setOnClickListener(this);
      kahaluButton.setOnClickListener(this);
      serpurButton.setOnClickListener(this);
      adomdighiButton.setOnClickListener(this);

    }

    @Override
    public void onClick(View v) {

        if(v.getId()==(R.id.bograButtonId)){
            intent=new Intent(MainActivity.this,UpazilaDescription.class);

            intent.putExtra("name","bogra");
            startActivity(intent);

        }
        if(v.getId()==(R.id.sadorButtonId)){
            intent=new Intent(MainActivity.this,UpazilaDescription.class);

            intent.putExtra("name","sador");
            startActivity(intent);

        }
        if(v.getId()==(R.id.sonatolaButtonId)){
            intent=new Intent(MainActivity.this,UpazilaDescription.class);

            intent.putExtra("name","sonatola");
            startActivity(intent);

        }
        if(v.getId()==(R.id.sariyakandiButtonId)){
            intent=new Intent(MainActivity.this,UpazilaDescription.class);

            intent.putExtra("name","sariyakandi");
            startActivity(intent);

        }
        if(v.getId()==(R.id.gabtoliButtonId)){asefjsaof q-tiskdl5sjn p8wn vs[ oitovksa v90KFIDSSO]
            intent=new Intent(MainActivity.this,UpazilaDescription.class);

            intent.putExtra("name","gabtoli");
            startActivity(intent);

        }
        if(v.getId()==(R.id.serpurButtonId)){
            intent=new Intent(MainActivity.this,UpazilaDescription.class);

            intent.putExtra("name","serpur");
            startActivity(intent);

        }
        if(v.getId()==(R.id.shahjahanpurButtonId)){
            intent=new Intent(MainActivity.this,UpazilaDescription.class);

            intent.putExtra("name","shahjahanpur");
            startActivity(intent);

        }
        if(v.getId()==(R.id.kahaluButtonId)){
            intent=new Intent(MainActivity.this,UpazilaDescription.class);

            intent.putExtra("name","kahalu");
            startActivity(intent);

        }
        if(v.getId()==(R.id.adomdighiButtonId)){
            intent=new Intent(MainActivity.this,UpazilaDescription.class);

            intent.putExtra("name","adomdighi");
            startActivity(intent);

        }
        if(v.getId()==(R.id.sibgonjButtonId)){
            intent=new Intent(MainActivity.this,UpazilaDescription.class);

            intent.putExtra("name","sib");
            startActivity(intent);

        }
        if(v.getId()==(R.id.)){
            intent=new Intent(MainActivity.this,UpazilaDescription.class);

            intent.putExtra("name","sib");
            startActivity(intent);

        }
    }
    public  void onBackPressed()
    {
        AlertDialog.Builder alertdialogbuilder;
        alertdialogbuilder=new AlertDialog.Builder(MainActivity.this);

        alertdialogbuilder.setIcon(R.drawable.questionicon);
        alertdialogbuilder.setTitle(R.string.title_text);
        alertdialogbuilder.setMessage(R.string.message_text);
        alertdialogbuilder.setCancelable(false);

        alertdialogbuilder.setPositiveButton("Yes", new DialogInterface.OnClickListener() {
            @Override
            public void onClick(DialogInterface dialog, int which) {

                finish();
            }
        });

        alertdialogbuilder.setPositiveButton("No", new DialogInterface.OnClickListener() {
            @Override
            public void onClick(DialogInterface dialog, int which) {

                dialog.cancel();
            }
        });
        AlertDialog alertDialog=alertdialogbuilder.create();
        alertDialog.show();




    }
}
