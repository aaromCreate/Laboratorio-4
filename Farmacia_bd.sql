--
-- PostgreSQL database dump
--

\restrict FI8OdCOhdmCooqF0nwCx8EfhdRONupYF9nByoq0AaxTebzHpx6bUbmiG0B7hSgj

-- Dumped from database version 18.0
-- Dumped by pg_dump version 18.0

-- Started on 2025-11-15 21:34:50

SET statement_timeout = 0;
SET lock_timeout = 0;
SET idle_in_transaction_session_timeout = 0;
SET transaction_timeout = 0;
SET client_encoding = 'UTF8';
SET standard_conforming_strings = on;
SELECT pg_catalog.set_config('search_path', '', false);
SET check_function_bodies = false;
SET xmloption = content;
SET client_min_messages = warning;
SET row_security = off;

--
-- TOC entry 229 (class 1255 OID 24716)
-- Name: agregar_medicamento(character varying, character varying, integer, numeric); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.agregar_medicamento(p_nombre character varying, p_imagen character varying, p_cantidad integer, p_precio numeric) RETURNS void
    LANGUAGE plpgsql
    AS $$
BEGIN
    INSERT INTO medicamentos(nombre, imagen, cantidad, precio)
    VALUES(p_nombre, p_imagen, p_cantidad, p_precio);
END;
$$;


ALTER FUNCTION public.agregar_medicamento(p_nombre character varying, p_imagen character varying, p_cantidad integer, p_precio numeric) OWNER TO postgres;

--
-- TOC entry 233 (class 1255 OID 24720)
-- Name: consultar_inventario(); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.consultar_inventario() RETURNS TABLE(id integer, nombre character varying, imagen character varying, cantidad integer, precio numeric)
    LANGUAGE plpgsql
    AS $$
BEGIN
    RETURN QUERY
    SELECT m.id, m.nombre, m.imagen, m.cantidad, m.precio
    FROM medicamentos m
    ORDER BY m.id;
END;
$$;


ALTER FUNCTION public.consultar_inventario() OWNER TO postgres;

--
-- TOC entry 235 (class 1255 OID 24722)
-- Name: consultar_pedidos(); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.consultar_pedidos() RETURNS TABLE(pedido_id integer, cliente character varying, total numeric, fecha timestamp without time zone)
    LANGUAGE plpgsql
    AS $$
BEGIN
    RETURN QUERY
    SELECT p.id,
           u.usuario AS cliente,
           p.total,
           p.fecha
    FROM pedidos p
    JOIN usuarios u ON p.cliente_id = u.id
    ORDER BY p.fecha DESC;
END;
$$;


ALTER FUNCTION public.consultar_pedidos() OWNER TO postgres;

--
-- TOC entry 231 (class 1255 OID 24718)
-- Name: eliminar_medicamento(integer); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.eliminar_medicamento(p_id integer) RETURNS void
    LANGUAGE plpgsql
    AS $$
BEGIN
    DELETE FROM medicamentos
    WHERE id = p_id;
END;
$$;


ALTER FUNCTION public.eliminar_medicamento(p_id integer) OWNER TO postgres;

--
-- TOC entry 227 (class 1255 OID 24714)
-- Name: login_usuario(character varying, character varying); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.login_usuario(p_usuario character varying, p_clave character varying) RETURNS TABLE(id integer, usuario character varying, tipo character varying)
    LANGUAGE plpgsql
    AS $$
BEGIN
    RETURN QUERY
    SELECT u.id, u.usuario, u.tipo
    FROM usuarios u
    WHERE u.usuario = p_usuario AND u.clave = p_clave;
END;
$$;


ALTER FUNCTION public.login_usuario(p_usuario character varying, p_clave character varying) OWNER TO postgres;

--
-- TOC entry 230 (class 1255 OID 24717)
-- Name: modificar_medicamento(integer, character varying, character varying, integer, numeric); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.modificar_medicamento(p_id integer, p_nombre character varying, p_imagen character varying, p_cantidad integer, p_precio numeric) RETURNS void
    LANGUAGE plpgsql
    AS $$
BEGIN
    UPDATE medicamentos
    SET nombre   = p_nombre,
        imagen   = p_imagen,
        cantidad = p_cantidad,
        precio   = p_precio
    WHERE id = p_id;
END;
$$;


ALTER FUNCTION public.modificar_medicamento(p_id integer, p_nombre character varying, p_imagen character varying, p_cantidad integer, p_precio numeric) OWNER TO postgres;

--
-- TOC entry 232 (class 1255 OID 24719)
-- Name: reabastecer_medicamento(integer, integer); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.reabastecer_medicamento(p_id integer, p_cantidad integer) RETURNS void
    LANGUAGE plpgsql
    AS $$
BEGIN
    UPDATE medicamentos
    SET cantidad = cantidad + p_cantidad
    WHERE id = p_id;
END;
$$;


ALTER FUNCTION public.reabastecer_medicamento(p_id integer, p_cantidad integer) OWNER TO postgres;

--
-- TOC entry 228 (class 1255 OID 24715)
-- Name: registrar_cliente(character varying, character varying); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.registrar_cliente(p_usuario character varying, p_clave character varying) RETURNS void
    LANGUAGE plpgsql
    AS $$
BEGIN
    INSERT INTO usuarios(usuario, clave, tipo)
    VALUES(p_usuario, p_clave, 'cliente');
END;
$$;


ALTER FUNCTION public.registrar_cliente(p_usuario character varying, p_clave character varying) OWNER TO postgres;

--
-- TOC entry 234 (class 1255 OID 24721)
-- Name: registrar_pedido(integer, integer, integer); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.registrar_pedido(p_cliente integer, p_medicamento integer, p_cantidad integer) RETURNS void
    LANGUAGE plpgsql
    AS $$
DECLARE
    v_precio NUMERIC;
    v_subtotal NUMERIC;
BEGIN
    -- Obtener precio del medicamento
    SELECT precio
    INTO v_precio
    FROM medicamentos
    WHERE id = p_medicamento;

    -- Calcular subtotal
    v_subtotal := v_precio * p_cantidad;

    -- Insertar pedido
    INSERT INTO pedidos(cliente_id, total)
    VALUES(p_cliente, v_subtotal);

    -- Insertar detalle del pedido
    INSERT INTO pedido_detalle(pedido_id, medicamento_id, cantidad, subtotal)
    VALUES(currval('pedidos_id_seq'), p_medicamento, p_cantidad, v_subtotal);

    -- Descontar inventario
    UPDATE medicamentos
    SET cantidad = cantidad - p_cantidad
    WHERE id = p_medicamento;
END;
$$;


ALTER FUNCTION public.registrar_pedido(p_cliente integer, p_medicamento integer, p_cantidad integer) OWNER TO postgres;

SET default_tablespace = '';

SET default_table_access_method = heap;

--
-- TOC entry 222 (class 1259 OID 24672)
-- Name: medicamentos; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.medicamentos (
    id integer NOT NULL,
    nombre character varying(100) NOT NULL,
    imagen character varying(300),
    cantidad integer NOT NULL,
    precio numeric(10,2) NOT NULL
);


ALTER TABLE public.medicamentos OWNER TO postgres;

--
-- TOC entry 221 (class 1259 OID 24671)
-- Name: medicamentos_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.medicamentos_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.medicamentos_id_seq OWNER TO postgres;

--
-- TOC entry 5058 (class 0 OID 0)
-- Dependencies: 221
-- Name: medicamentos_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.medicamentos_id_seq OWNED BY public.medicamentos.id;


--
-- TOC entry 226 (class 1259 OID 24697)
-- Name: pedido_detalle; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.pedido_detalle (
    id integer NOT NULL,
    pedido_id integer,
    medicamento_id integer,
    cantidad integer,
    subtotal numeric(10,2)
);


ALTER TABLE public.pedido_detalle OWNER TO postgres;

--
-- TOC entry 225 (class 1259 OID 24696)
-- Name: pedido_detalle_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.pedido_detalle_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.pedido_detalle_id_seq OWNER TO postgres;

--
-- TOC entry 5059 (class 0 OID 0)
-- Dependencies: 225
-- Name: pedido_detalle_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.pedido_detalle_id_seq OWNED BY public.pedido_detalle.id;


--
-- TOC entry 224 (class 1259 OID 24683)
-- Name: pedidos; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.pedidos (
    id integer NOT NULL,
    cliente_id integer,
    fecha timestamp without time zone DEFAULT now(),
    total numeric(10,2)
);


ALTER TABLE public.pedidos OWNER TO postgres;

--
-- TOC entry 223 (class 1259 OID 24682)
-- Name: pedidos_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.pedidos_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.pedidos_id_seq OWNER TO postgres;

--
-- TOC entry 5060 (class 0 OID 0)
-- Dependencies: 223
-- Name: pedidos_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.pedidos_id_seq OWNED BY public.pedidos.id;


--
-- TOC entry 220 (class 1259 OID 24659)
-- Name: usuarios; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.usuarios (
    id integer NOT NULL,
    usuario character varying(50) NOT NULL,
    clave character varying(200) NOT NULL,
    tipo character varying(20) NOT NULL
);


ALTER TABLE public.usuarios OWNER TO postgres;

--
-- TOC entry 219 (class 1259 OID 24658)
-- Name: usuarios_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.usuarios_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.usuarios_id_seq OWNER TO postgres;

--
-- TOC entry 5061 (class 0 OID 0)
-- Dependencies: 219
-- Name: usuarios_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.usuarios_id_seq OWNED BY public.usuarios.id;


--
-- TOC entry 4881 (class 2604 OID 24675)
-- Name: medicamentos id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.medicamentos ALTER COLUMN id SET DEFAULT nextval('public.medicamentos_id_seq'::regclass);


--
-- TOC entry 4884 (class 2604 OID 24700)
-- Name: pedido_detalle id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.pedido_detalle ALTER COLUMN id SET DEFAULT nextval('public.pedido_detalle_id_seq'::regclass);


--
-- TOC entry 4882 (class 2604 OID 24686)
-- Name: pedidos id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.pedidos ALTER COLUMN id SET DEFAULT nextval('public.pedidos_id_seq'::regclass);


--
-- TOC entry 4880 (class 2604 OID 24662)
-- Name: usuarios id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.usuarios ALTER COLUMN id SET DEFAULT nextval('public.usuarios_id_seq'::regclass);


--
-- TOC entry 5048 (class 0 OID 24672)
-- Dependencies: 222
-- Data for Name: medicamentos; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.medicamentos (id, nombre, imagen, cantidad, precio) FROM stdin;
2	Ibuprofeno	imagenes/Ibuprofeno.png	50	1.20
3	Amoxicilina	imagenes/Amoxicilina.png	30	2.50
4	Loratadina	imagenes/Loratadina.png	75	0.75
5	Omeprazol	imagenes/Omeprazol.png	200	0.60
1	Paracetamol	imagenes/Paracetamol.png	93	0.50
\.


--
-- TOC entry 5052 (class 0 OID 24697)
-- Dependencies: 226
-- Data for Name: pedido_detalle; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.pedido_detalle (id, pedido_id, medicamento_id, cantidad, subtotal) FROM stdin;
1	4	1	7	3.50
\.


--
-- TOC entry 5050 (class 0 OID 24683)
-- Dependencies: 224
-- Data for Name: pedidos; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.pedidos (id, cliente_id, fecha, total) FROM stdin;
4	2	2025-11-15 21:01:23.542505	3.50
\.


--
-- TOC entry 5046 (class 0 OID 24659)
-- Dependencies: 220
-- Data for Name: usuarios; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.usuarios (id, usuario, clave, tipo) FROM stdin;
1	admin	123	admin
2	cliente	123	cliente
3	Jorge	Jorge123!	cliente
\.


--
-- TOC entry 5062 (class 0 OID 0)
-- Dependencies: 221
-- Name: medicamentos_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.medicamentos_id_seq', 5, true);


--
-- TOC entry 5063 (class 0 OID 0)
-- Dependencies: 225
-- Name: pedido_detalle_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.pedido_detalle_id_seq', 1, true);


--
-- TOC entry 5064 (class 0 OID 0)
-- Dependencies: 223
-- Name: pedidos_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.pedidos_id_seq', 4, true);


--
-- TOC entry 5065 (class 0 OID 0)
-- Dependencies: 219
-- Name: usuarios_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.usuarios_id_seq', 3, true);


--
-- TOC entry 4890 (class 2606 OID 24681)
-- Name: medicamentos medicamentos_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.medicamentos
    ADD CONSTRAINT medicamentos_pkey PRIMARY KEY (id);


--
-- TOC entry 4894 (class 2606 OID 24703)
-- Name: pedido_detalle pedido_detalle_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.pedido_detalle
    ADD CONSTRAINT pedido_detalle_pkey PRIMARY KEY (id);


--
-- TOC entry 4892 (class 2606 OID 24690)
-- Name: pedidos pedidos_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.pedidos
    ADD CONSTRAINT pedidos_pkey PRIMARY KEY (id);


--
-- TOC entry 4886 (class 2606 OID 24668)
-- Name: usuarios usuarios_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.usuarios
    ADD CONSTRAINT usuarios_pkey PRIMARY KEY (id);


--
-- TOC entry 4888 (class 2606 OID 24670)
-- Name: usuarios usuarios_usuario_key; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.usuarios
    ADD CONSTRAINT usuarios_usuario_key UNIQUE (usuario);


--
-- TOC entry 4896 (class 2606 OID 24709)
-- Name: pedido_detalle pedido_detalle_medicamento_id_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.pedido_detalle
    ADD CONSTRAINT pedido_detalle_medicamento_id_fkey FOREIGN KEY (medicamento_id) REFERENCES public.medicamentos(id);


--
-- TOC entry 4897 (class 2606 OID 24704)
-- Name: pedido_detalle pedido_detalle_pedido_id_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.pedido_detalle
    ADD CONSTRAINT pedido_detalle_pedido_id_fkey FOREIGN KEY (pedido_id) REFERENCES public.pedidos(id);


--
-- TOC entry 4895 (class 2606 OID 24691)
-- Name: pedidos pedidos_cliente_id_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.pedidos
    ADD CONSTRAINT pedidos_cliente_id_fkey FOREIGN KEY (cliente_id) REFERENCES public.usuarios(id);


-- Completed on 2025-11-15 21:34:50

--
-- PostgreSQL database dump complete
--

\unrestrict FI8OdCOhdmCooqF0nwCx8EfhdRONupYF9nByoq0AaxTebzHpx6bUbmiG0B7hSgj

