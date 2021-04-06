package com.example.sumon.bogradistrict;

import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.widget.ImageView;
import android.widget.TextView;

public class UpazilaDescription extends AppCompatActivity {

    private ImageView imageView;
    private TextView textView;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_upazila_description);

        imageView = (ImageView) findViewById(R.id.imageButtonId);

        textView = (TextView) findViewById(R.id.textViewId);

        Bundle bundle = getIntent().getExtras();

        if (bundle != null) {
            String countryname=bundle.getString("name");
            showdetails(countryname);


        }

    }
    void showdetails(String countryname)
    {

        if(countryname.equals("bogra"))
        {

            imageView.setImageResource(R.drawable.mohasthangor1);
            textView.setText(R.string.bogra_text);

        }
        if(countryname.equals("sador"))
        {

            imageView.setImageResource(R.drawable.lalbagh);
            textView.setText(R.string.sador_text);

        }
        if(countryname.equals("sonatola"))
        {

            imageView.setImageResource(R.drawable.khanjahanmajar);
            textView.setText(R.string.sonatola_text);

        }
        if(countryname.equals("sariyakandi"))
        {

            imageView.setImageResource(R.drawable.kuyakata);
            textView.setText(R.string.sariyakandi_text);

        }
        if(countryname.equals("shahjahanpur"))
        {

            imageView.setImageResource(R.drawable.baburpukur);
            textView.setText(R.string.shahjahanpur_text);

        }
        if(countryname.equals("gabtoli"))
        {

            imageView.setImageResource(R.drawable.darasbarimosque);
            textView.setText(R.string.gabtoli_text);

        }
        if(countryname.equals("kahalu"))
        {

            imageView.setImageResource(R.drawable.sixtydomemosque);
            textView.setText(R.string.kahalu_text);

        }
        if(countryname.equals("serpur"))
        {

            imageView.setImageResource(R.drawable.sompurbhihar);
            textView.setText(R.string.serpur_text);

        }
        if(countryname.equals("adomdighi"))
        {

            imageView.setImageResource(R.drawable.sundorban);
            textView.setText(R.string.adomdighi_text);

        }
        if(countryname.equals("sib"))
        {

            imageView.setImageResource(R.drawable.ahsanmonjil);
            textView.setText(R.string.sibgonj_text);

        }
    }
}
