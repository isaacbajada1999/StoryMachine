PGDMP     '    (                v        
   Assignment    10.3    10.3 (               0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                       false                       0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                       false                       0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                       false                       1262    16393 
   Assignment    DATABASE     �   CREATE DATABASE "Assignment" WITH TEMPLATE = template0 ENCODING = 'UTF8' LC_COLLATE = 'Maltese_Malta.1252' LC_CTYPE = 'Maltese_Malta.1252';
    DROP DATABASE "Assignment";
             postgres    false                        2615    2200    public    SCHEMA        CREATE SCHEMA public;
    DROP SCHEMA public;
             postgres    false                       0    0    SCHEMA public    COMMENT     6   COMMENT ON SCHEMA public IS 'standard public schema';
                  postgres    false    3                        3079    12924    plpgsql 	   EXTENSION     ?   CREATE EXTENSION IF NOT EXISTS plpgsql WITH SCHEMA pg_catalog;
    DROP EXTENSION plpgsql;
                  false                        0    0    EXTENSION plpgsql    COMMENT     @   COMMENT ON EXTENSION plpgsql IS 'PL/pgSQL procedural language';
                       false    1            �            1259    16409    ChosenOption    TABLE     h   CREATE TABLE public."ChosenOption" (
    "StateID" integer NOT NULL,
    "OptionID" integer NOT NULL
);
 "   DROP TABLE public."ChosenOption";
       public         postgres    false    3            �            1259    16406    Options    TABLE     �   CREATE TABLE public."Options" (
    "ID" integer NOT NULL,
    "PassageID" integer,
    "Text" "char",
    "RequiredOptionID" integer
);
    DROP TABLE public."Options";
       public         postgres    false    3            �            1259    16403    Passage    TABLE     �   CREATE TABLE public."Passage" (
    "ID" integer NOT NULL,
    "StoryID" integer,
    "Title" "char",
    "Description" "char"
);
    DROP TABLE public."Passage";
       public         postgres    false    3            �            1259    16397    PlayerDetails    TABLE     V   CREATE TABLE public."PlayerDetails" (
    "ID" integer NOT NULL,
    "Name" "char"
);
 #   DROP TABLE public."PlayerDetails";
       public         postgres    false    3            �            1259    16400    State    TABLE     �   CREATE TABLE public."State" (
    "ID" integer NOT NULL,
    "PlayerID" integer,
    "StoryID" integer,
    "PassageID" integer
);
    DROP TABLE public."State";
       public         postgres    false    3            �            1259    16394    Stories    TABLE     P   CREATE TABLE public."Stories" (
    "Id" integer NOT NULL,
    "Name" "char"
);
    DROP TABLE public."Stories";
       public         postgres    false    3                      0    16409    ChosenOption 
   TABLE DATA               ?   COPY public."ChosenOption" ("StateID", "OptionID") FROM stdin;
    public       postgres    false    201   F*                 0    16406    Options 
   TABLE DATA               R   COPY public."Options" ("ID", "PassageID", "Text", "RequiredOptionID") FROM stdin;
    public       postgres    false    200   c*                 0    16403    Passage 
   TABLE DATA               L   COPY public."Passage" ("ID", "StoryID", "Title", "Description") FROM stdin;
    public       postgres    false    199   �*                 0    16397    PlayerDetails 
   TABLE DATA               7   COPY public."PlayerDetails" ("ID", "Name") FROM stdin;
    public       postgres    false    197   �*                 0    16400    State 
   TABLE DATA               K   COPY public."State" ("ID", "PlayerID", "StoryID", "PassageID") FROM stdin;
    public       postgres    false    198   �*                 0    16394    Stories 
   TABLE DATA               1   COPY public."Stories" ("Id", "Name") FROM stdin;
    public       postgres    false    196   �*       �
           2606    32807 (   ChosenOption ChosenOptionStateIdOptionId 
   CONSTRAINT     }   ALTER TABLE ONLY public."ChosenOption"
    ADD CONSTRAINT "ChosenOptionStateIdOptionId" PRIMARY KEY ("StateID", "OptionID");
 V   ALTER TABLE ONLY public."ChosenOption" DROP CONSTRAINT "ChosenOptionStateIdOptionId";
       public         postgres    false    201    201            �
           2606    32784    Stories IdPrimaryKey 
   CONSTRAINT     X   ALTER TABLE ONLY public."Stories"
    ADD CONSTRAINT "IdPrimaryKey" PRIMARY KEY ("Id");
 B   ALTER TABLE ONLY public."Stories" DROP CONSTRAINT "IdPrimaryKey";
       public         postgres    false    196            �
           2606    32803    Options OptionsId 
   CONSTRAINT     U   ALTER TABLE ONLY public."Options"
    ADD CONSTRAINT "OptionsId" PRIMARY KEY ("ID");
 ?   ALTER TABLE ONLY public."Options" DROP CONSTRAINT "OptionsId";
       public         postgres    false    200            �
           2606    32801    Passage PassageId 
   CONSTRAINT     U   ALTER TABLE ONLY public."Passage"
    ADD CONSTRAINT "PassageId" PRIMARY KEY ("ID");
 ?   ALTER TABLE ONLY public."Passage" DROP CONSTRAINT "PassageId";
       public         postgres    false    199            �
           2606    32788    PlayerDetails PlayerDeatailsPk 
   CONSTRAINT     b   ALTER TABLE ONLY public."PlayerDetails"
    ADD CONSTRAINT "PlayerDeatailsPk" PRIMARY KEY ("ID");
 L   ALTER TABLE ONLY public."PlayerDetails" DROP CONSTRAINT "PlayerDeatailsPk";
       public         postgres    false    197            �
           2606    32786    State StateIdPrimaryKey 
   CONSTRAINT     [   ALTER TABLE ONLY public."State"
    ADD CONSTRAINT "StateIdPrimaryKey" PRIMARY KEY ("ID");
 E   ALTER TABLE ONLY public."State" DROP CONSTRAINT "StateIdPrimaryKey";
       public         postgres    false    198            �
           1259    32823    fki_ChosenOptionId    INDEX     T   CREATE INDEX "fki_ChosenOptionId" ON public."ChosenOption" USING btree ("StateID");
 (   DROP INDEX public."fki_ChosenOptionId";
       public         postgres    false    201            �
           1259    32829    fki_ChosenOptionOptionId    INDEX     [   CREATE INDEX "fki_ChosenOptionOptionId" ON public."ChosenOption" USING btree ("OptionID");
 .   DROP INDEX public."fki_ChosenOptionOptionId";
       public         postgres    false    201            �
           1259    32835    fki_OptionsPassageId    INDEX     S   CREATE INDEX "fki_OptionsPassageId" ON public."Options" USING btree ("PassageID");
 *   DROP INDEX public."fki_OptionsPassageId";
       public         postgres    false    200            �
           1259    32841    fki_PassageStoryId    INDEX     O   CREATE INDEX "fki_PassageStoryId" ON public."Passage" USING btree ("StoryID");
 (   DROP INDEX public."fki_PassageStoryId";
       public         postgres    false    199            �
           1259    32853    fki_StatePassageId    INDEX     O   CREATE INDEX "fki_StatePassageId" ON public."State" USING btree ("PassageID");
 (   DROP INDEX public."fki_StatePassageId";
       public         postgres    false    198            �
           1259    32799    fki_StatePlayerId    INDEX     M   CREATE INDEX "fki_StatePlayerId" ON public."State" USING btree ("PlayerID");
 '   DROP INDEX public."fki_StatePlayerId";
       public         postgres    false    198            �
           1259    32847    fki_StateStoryId    INDEX     K   CREATE INDEX "fki_StateStoryId" ON public."State" USING btree ("StoryID");
 &   DROP INDEX public."fki_StateStoryId";
       public         postgres    false    198            �
           2606    32818    ChosenOption ChosenOptionId    FK CONSTRAINT     �   ALTER TABLE ONLY public."ChosenOption"
    ADD CONSTRAINT "ChosenOptionId" FOREIGN KEY ("StateID") REFERENCES public."State"("ID");
 I   ALTER TABLE ONLY public."ChosenOption" DROP CONSTRAINT "ChosenOptionId";
       public       postgres    false    2693    201    198            �
           2606    32824 !   ChosenOption ChosenOptionOptionId    FK CONSTRAINT     �   ALTER TABLE ONLY public."ChosenOption"
    ADD CONSTRAINT "ChosenOptionOptionId" FOREIGN KEY ("OptionID") REFERENCES public."Options"("ID");
 O   ALTER TABLE ONLY public."ChosenOption" DROP CONSTRAINT "ChosenOptionOptionId";
       public       postgres    false    201    2701    200            �
           2606    32830    Options OptionsPassageId    FK CONSTRAINT     �   ALTER TABLE ONLY public."Options"
    ADD CONSTRAINT "OptionsPassageId" FOREIGN KEY ("PassageID") REFERENCES public."Passage"("ID");
 F   ALTER TABLE ONLY public."Options" DROP CONSTRAINT "OptionsPassageId";
       public       postgres    false    199    200    2698            �
           2606    32836    Passage PassageStoryId    FK CONSTRAINT     �   ALTER TABLE ONLY public."Passage"
    ADD CONSTRAINT "PassageStoryId" FOREIGN KEY ("StoryID") REFERENCES public."Stories"("Id");
 D   ALTER TABLE ONLY public."Passage" DROP CONSTRAINT "PassageStoryId";
       public       postgres    false    196    199    2689            �
           2606    32848    State StatePassageId    FK CONSTRAINT     �   ALTER TABLE ONLY public."State"
    ADD CONSTRAINT "StatePassageId" FOREIGN KEY ("PassageID") REFERENCES public."Passage"("ID");
 B   ALTER TABLE ONLY public."State" DROP CONSTRAINT "StatePassageId";
       public       postgres    false    199    198    2698            �
           2606    32794    State StatePlayerId    FK CONSTRAINT     �   ALTER TABLE ONLY public."State"
    ADD CONSTRAINT "StatePlayerId" FOREIGN KEY ("PlayerID") REFERENCES public."PlayerDetails"("ID");
 A   ALTER TABLE ONLY public."State" DROP CONSTRAINT "StatePlayerId";
       public       postgres    false    2691    198    197            �
           2606    32842    State StateStoryId    FK CONSTRAINT     }   ALTER TABLE ONLY public."State"
    ADD CONSTRAINT "StateStoryId" FOREIGN KEY ("StoryID") REFERENCES public."Stories"("Id");
 @   ALTER TABLE ONLY public."State" DROP CONSTRAINT "StateStoryId";
       public       postgres    false    196    2689    198                  x������ � �            x������ � �            x������ � �            x������ � �            x������ � �            x������ � �     